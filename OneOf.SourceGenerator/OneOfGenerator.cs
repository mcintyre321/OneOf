﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OneOf.SourceGenerator
{
    [Generator]
    public class OneOfGenerator : IIncrementalGenerator
    {
        private const string AttributeName = "GenerateOneOfAttribute";
        private const string AttributeNamespace = "OneOf";

        private readonly string _attributeText = $@"// <auto-generated />
using System;

#pragma warning disable 1591

namespace {AttributeNamespace}
{{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    internal sealed class {AttributeName} : Attribute
    {{
    }}
}}
";

        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            context.RegisterPostInitializationOutput(ctx => ctx.AddSource($"{AttributeName}.g.cs", _attributeText));

            var oneOfClasses = context.SyntaxProvider
                .CreateSyntaxProvider(
                    predicate: static (s, _) => IsSyntaxTargetForGeneration(s),
                    transform: static (ctx, _) => GetSemanticTargetForGeneration(ctx))
                .Where(static m => m is not null);

            var generationSpecAndDiagnostics = oneOfClasses.Select(ParseOneOf);

            // output the diagnostics
            var diagnostics = generationSpecAndDiagnostics.Select(static (x, _) => x.Diagnostics);
            context.RegisterSourceOutput(diagnostics, static (context, diagnostics) =>
            {
                foreach (var diagnostic in diagnostics)
                {
                    context.ReportDiagnostic(diagnostic);
                }
            });
            
            // output the OneOf classes
            var generationSpec = generationSpecAndDiagnostics.Select(static (x, _) => x.OneOfGenerationSpec);
            context.RegisterSourceOutput(generationSpec, static (context, generationSpec) =>
            {
                if (generationSpec == null)
                {
                    return;
                }

                var oneOf = generationSpec.Value;
                context.AddSource($"{oneOf.ContainingNamespace}_{oneOf.MemberName}.g.cs", EmitOneOf(oneOf));
            });

            static bool IsSyntaxTargetForGeneration(SyntaxNode node)
            {
                return node is ClassDeclarationSyntax { AttributeLists: { Count: > 0 } } classDeclarationSyntax
                       && classDeclarationSyntax.Modifiers.Any(SyntaxKind.PartialKeyword);
            }

            static INamedTypeSymbol? GetSemanticTargetForGeneration(GeneratorSyntaxContext context)
            {
                var symbol = context.SemanticModel.GetDeclaredSymbol(context.Node);

                if (symbol is not INamedTypeSymbol namedTypeSymbol)
                {
                    return null;
                }

                var attributeData = namedTypeSymbol.GetAttributes().FirstOrDefault(ad =>
                    string.Equals(ad.AttributeClass?.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
                        $"global::{AttributeNamespace}.{AttributeName}"));

                return attributeData is null ? null : namedTypeSymbol;
            }
        }

        private static (OneOfGenerationSpec? OneOfGenerationSpec, ImmutableEquatableArray<Diagnostic> Diagnostics) ParseOneOf(INamedTypeSymbol? classSymbol, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var diagnostics = new List<Diagnostic>();
            if (classSymbol is null)
            {
                return (null, ImmutableEquatableArray<Diagnostic>.Empty);
            }

            var attributeLocation = classSymbol.Locations.FirstOrDefault() ?? Location.None;

            if (!classSymbol.ContainingSymbol.Equals(classSymbol.ContainingNamespace, SymbolEqualityComparer.Default))
            {
                return ReturnDiagnostic(GeneratorDiagnosticDescriptors.TopLevelError);
            }

            if (classSymbol.BaseType is null || classSymbol.BaseType.Name != "OneOfBase" ||
                classSymbol.BaseType.ContainingNamespace.ToString() != "OneOf")
            {
                return ReturnDiagnostic(GeneratorDiagnosticDescriptors.WrongBaseType);
            }

            var typeArguments = classSymbol.BaseType.TypeArguments;

            foreach (var typeSymbol in typeArguments)
            {
                if (typeSymbol.Name == nameof(Object))
                {
                    return ReturnDiagnostic(GeneratorDiagnosticDescriptors.ObjectIsOneOfType);
                }

                if (typeSymbol.TypeKind == TypeKind.Interface)
                {
                    return ReturnDiagnostic(GeneratorDiagnosticDescriptors.UserDefinedConversionsToOrFromAnInterfaceAreNotAllowed);
                }
            }

            var openGenericTypeArgs = classSymbol.TypeArguments.Select(x => x.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)).ToImmutableEquatableArray();
            var typeArg = typeArguments.Select(x => x.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)).ToImmutableEquatableArray();
            var typeParameters = classSymbol.BaseType.TypeParameters.Select(x => x.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)).ToImmutableEquatableArray();
            var oneOfGenerationSpec = new OneOfGenerationSpec(classSymbol.Name, classSymbol.ContainingNamespace.ToDisplayString(),
                openGenericTypeArgs, typeParameters, typeArg);

            cancellationToken.ThrowIfCancellationRequested();
            return (oneOfGenerationSpec, diagnostics.ToImmutableEquatableArray());

            (OneOfGenerationSpec?, ImmutableEquatableArray<Diagnostic>) ReturnDiagnostic(DiagnosticDescriptor descriptor)
            {
                var diagnostic = Diagnostic.Create(descriptor, attributeLocation, classSymbol.Name,
                    descriptor.DefaultSeverity);
                diagnostics.Add(diagnostic);
                return (null, diagnostics.ToImmutableEquatableArray());
            }
        }

        private static string EmitOneOf(OneOfGenerationSpec spec)
        {
            var paramArgPairs =
                spec.TypeParameters.Zip(spec.TypeArguments, (param, arg) => (param, arg));

            var oneOfGenericPart = GetGenericPart(spec.TypeArguments);

            var classNameWithGenericTypes = $"{spec.MemberName}{GetOpenGenericPart(spec.OpenGenericTypeArguments)}";

            StringBuilder source = new($@"// <auto-generated />
#pragma warning disable 1591

namespace {spec.ContainingNamespace}
{{
    partial class {classNameWithGenericTypes}");

            source.Append($@"
    {{
        public {spec.MemberName}(OneOf.OneOf<{oneOfGenericPart}> _) : base(_) {{ }}
");

            foreach (var (param, arg) in paramArgPairs)
            {
                source.Append($@"
        public static implicit operator {classNameWithGenericTypes}({arg} _) => new {classNameWithGenericTypes}(_);
        public static explicit operator {arg}({classNameWithGenericTypes} _) => _.As{param};
");
            }

            source.Append(@"    }
}");
            return source.ToString();
        }

        private static string GetGenericPart(ImmutableEquatableArray<string> typeArguments) =>
            string.Join(", ", typeArguments.Select(x => x));

        private static string? GetOpenGenericPart(ImmutableEquatableArray<string> typeArguments)
        {
            if (!typeArguments.Any())
            {
                return null;
            }

            return $"<{GetGenericPart(typeArguments)}>";
        }
    }

    internal record struct OneOfGenerationSpec(string MemberName, string ContainingNamespace,
        ImmutableEquatableArray<string> OpenGenericTypeArguments, ImmutableEquatableArray<string> TypeParameters,
        ImmutableEquatableArray<string> TypeArguments);
}


