using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace OneOf.SourceGenerator
{
    [Generator]
    public class OneOfGenerator : ISourceGenerator
    {

        private static readonly DiagnosticDescriptor _topLevelError = new(id: "ONEOFGEN001",
                                                                                              title: "Class must be top level",
                                                                                              messageFormat: "Class '{0}' using OneOfGenerator must be top level",
                                                                                              category: "OneOfGenerator",
                                                                                              DiagnosticSeverity.Error,
                                                                                              isEnabledByDefault: true);

        private static readonly DiagnosticDescriptor _wrongBaseType = new(id: "ONEOFGEN002",
                                                                                              title: "Class must inherit from OneOfBase",
                                                                                              messageFormat: "Class '{0}' does not inherit from OneOfBase",
                                                                                              category: "OneOfGenerator",
                                                                                              DiagnosticSeverity.Error,
                                                                                              isEnabledByDefault: true);

        private static readonly DiagnosticDescriptor _classIsNotPublic = new(id: "ONEOFGEN003",
                                                                                              title: "Class must be public",
                                                                                              messageFormat: "Class '{0}' is not public",
                                                                                              category: "OneOfGenerator",
                                                                                              DiagnosticSeverity.Error,
                                                                                              isEnabledByDefault: true);

        private static readonly DiagnosticDescriptor _objectIsOneOfType = new(id: "ONEOFGEN004",
                                                                                              title: "Object is not a valid type parameter",
                                                                                              messageFormat: "Defined conversions to or from a base type are not allowed for class '{0}'",
                                                                                              category: "OneOfGenerator",
                                                                                              DiagnosticSeverity.Error,
                                                                                              isEnabledByDefault: true);

        private const string _attributeName = "GenerateOneOfAttribute";
        private const string _attributeNamespace = "OneOf";
        private readonly string _attributeText = $@"using System;

namespace {_attributeNamespace}
{{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class {_attributeName} : Attribute
    {{
    }}
}}
        ";

        public void Execute(GeneratorExecutionContext context)
        {
            context.AddSource(_attributeName, SourceText.From(_attributeText, Encoding.UTF8));

            if (context.SyntaxReceiver is not OneOfSyntaxReceiver receiver)
            {
                return;
            }

            if ((context.Compilation as CSharpCompilation)?.SyntaxTrees[0].Options is not CSharpParseOptions options)
            {
                return;
            }

            Compilation compilation = context.Compilation.AddSyntaxTrees(CSharpSyntaxTree.ParseText(SourceText.From(_attributeText, Encoding.UTF8), options));

            INamedTypeSymbol? attributeSymbol = compilation.GetTypeByMetadataName($"{_attributeNamespace}.{_attributeName}");

            if (attributeSymbol is null)
            {
                return;
            }

            List<(INamedTypeSymbol, Location?)> namedTypeSymbols = new();
            foreach (ClassDeclarationSyntax classDeclaration in receiver.CandidateClasses)
            {
                SemanticModel model = compilation.GetSemanticModel(classDeclaration.SyntaxTree);
                INamedTypeSymbol? namedTypeSymbol = model.GetDeclaredSymbol(classDeclaration);

                AttributeData? attributeData = namedTypeSymbol?.GetAttributes().FirstOrDefault(ad => ad.AttributeClass?.Equals(attributeSymbol, SymbolEqualityComparer.Default) != false);

                if (attributeData is object)
                {
                    namedTypeSymbols.Add((namedTypeSymbol!, attributeData.ApplicationSyntaxReference?.GetSyntax().GetLocation()));
                }
            }

            foreach ((INamedTypeSymbol namedSymnbol, Location? attributeLocation) in namedTypeSymbols)
            {
                string? classSource = ProcessClass(namedSymnbol, context, attributeLocation);

                if (classSource is null)
                {
                    continue;
                }

                context.AddSource($"{namedSymnbol.ContainingNamespace}_{namedSymnbol.Name}.generated.cs", SourceText.From(classSource, Encoding.UTF8));
            }
        }

        private string? ProcessClass(INamedTypeSymbol classSymbol, GeneratorExecutionContext context, Location? attributeLocation)
        {
            attributeLocation ??= Location.None;

            if (!classSymbol.ContainingSymbol.Equals(classSymbol.ContainingNamespace, SymbolEqualityComparer.Default))
            {
                context.ReportDiagnostic(Diagnostic.Create(_topLevelError, attributeLocation, classSymbol.Name, DiagnosticSeverity.Error));
                return null;
            }

            if (classSymbol.BaseType is null || classSymbol.BaseType.Name != "OneOfBase" || classSymbol.BaseType.ContainingNamespace.ToString() != "OneOf")
            {
                context.ReportDiagnostic(Diagnostic.Create(_wrongBaseType, attributeLocation, classSymbol.Name, DiagnosticSeverity.Error));
                return null;
            }

            if (classSymbol.DeclaredAccessibility != Accessibility.Public)
            {
                context.ReportDiagnostic(Diagnostic.Create(_classIsNotPublic, attributeLocation, classSymbol.Name, DiagnosticSeverity.Error));
                return null;
            }

            ImmutableArray<ITypeParameterSymbol> typeParameters = classSymbol.BaseType.TypeParameters;
            ImmutableArray<ITypeSymbol> typeArguments = classSymbol.BaseType.TypeArguments;

            if (typeArguments.Any(x => x.Name == nameof(Object)))
            {
                context.ReportDiagnostic(Diagnostic.Create(_objectIsOneOfType, attributeLocation, classSymbol.Name, DiagnosticSeverity.Error));
                return null;
            }

            IEnumerable<(ITypeParameterSymbol param, ITypeSymbol arg)> paramArgPairs = typeParameters.Zip(typeArguments, (param, arg) => (param, arg));

            string generics = string.Join(", ", typeArguments.Select(x => x.GetFullName()));

            StringBuilder source = new($@"using System;

namespace {classSymbol.ContainingNamespace.ToDisplayString()}
{{
    public partial class {classSymbol.Name}
    {{
        public {classSymbol.Name}(OneOf.OneOf<{generics}> _) : base(_) {{ }}
");

            foreach ((ITypeParameterSymbol param, ITypeSymbol arg) in paramArgPairs)
            {
                source.Append($@"
        public static implicit operator {classSymbol.Name}({arg.GetFullName()} _) => new {classSymbol.Name}(_);
        public static implicit operator {arg.GetFullName()}({classSymbol.Name} _) => _.As{param.Name};
");
            }

            source.Append($@"    }}
}}");
            return source.ToString();
        }

        public void Initialize(GeneratorInitializationContext context)
            => context.RegisterForSyntaxNotifications(() => new OneOfSyntaxReceiver());
    }

    class OneOfSyntaxReceiver : ISyntaxReceiver
    {
        public List<ClassDeclarationSyntax> CandidateClasses { get; } = new();

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            if (syntaxNode is ClassDeclarationSyntax classDeclarationSyntax
                && classDeclarationSyntax.AttributeLists.Count > 0 &&
                classDeclarationSyntax.Modifiers.Any(SyntaxKind.PartialKeyword))
            {
                CandidateClasses.Add(classDeclarationSyntax);
            }
        }
    }
}
