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
        private const string _attributeName = "GenerateOneOfAttribute";
        private const string _attributeNamespace = "OneOf";
        private readonly string _attributeText = $@"using System;

namespace {_attributeNamespace}
{{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class {_attributeName} : Attribute
    {{
        public string[] TypeNames {{ get; }}
        public {_attributeName}(params string[] typeNames) {{
            this.TypeNames = typeNames;
        }}
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

            List<(INamedTypeSymbol, AttributeData)> namedTypeSymbols = new();
            foreach (ClassDeclarationSyntax classDeclaration in receiver.CandidateClasses)
            {
                SemanticModel model = compilation.GetSemanticModel(classDeclaration.SyntaxTree);
                INamedTypeSymbol? namedTypeSymbol = model.GetDeclaredSymbol(classDeclaration);

                AttributeData? attributeData = namedTypeSymbol?.GetAttributes().FirstOrDefault(ad => ad.AttributeClass?.Equals(attributeSymbol, SymbolEqualityComparer.Default) != false);

                if (attributeData is object)
                {
                    namedTypeSymbols.Add((namedTypeSymbol!, attributeData));
                }
            }

            foreach (var (namedSymbol, attributeData) in namedTypeSymbols)
            {
                var attributeLocation = attributeData.ApplicationSyntaxReference?.GetSyntax().GetLocation();
                var typeNames = attributeData.ConstructorArguments.First().Values;
                string? classSource = ProcessClass(namedSymbol, context, attributeLocation, typeNames);

                if (classSource is null)
                {
                    continue;
                }

                context.AddSource($"{namedSymbol.ContainingNamespace}_{namedSymbol.Name}.generated.cs", SourceText.From(classSource, Encoding.UTF8));
            }
        }

        private static string? ProcessClass(INamedTypeSymbol classSymbol, GeneratorExecutionContext context, Location? attributeLocation, ImmutableArray<TypedConstant> typeNames)
        {
            attributeLocation ??= Location.None;

            var diagnostics = new List<Diagnostic>();
            if (!context.ValidateClass(classSymbol, attributeLocation))
                return null;

            var typeParameters = classSymbol.BaseType.TypeParameters;
            var typeArguments = classSymbol.BaseType.TypeArguments;

            if (!context.ValidateTypeArguments(classSymbol, attributeLocation, typeArguments))
                return null;

            if (!context.ValidateTypeNames(classSymbol, attributeLocation, typeArguments, typeNames))
                return null;

            var paramArgPairs = typeParameters.Zip(typeArguments, (param, arg) => (param: param, arg: arg));
            var paramArgsAndNames = paramArgPairs.Zip(typeNames, (pa, name) => (param: pa.param, arg: pa.arg, name: name));

            var generics = string.Join(", ", typeArguments.Select(x => x.ToDisplayString()));

            StringBuilder source = new($@"using System;

namespace {classSymbol.ContainingNamespace.ToDisplayString()}
{{
    public partial class {classSymbol.Name}
    {{
        public {classSymbol.Name}(OneOf.OneOf<{generics}> _) : base(_) {{ }}
");
            foreach (var (param, arg) in paramArgPairs)
            {
                source.Append($@"
        public static implicit operator {classSymbol.Name}({arg.ToDisplayString()} _) => new {classSymbol.Name}(_);
        public static explicit operator {arg.ToDisplayString()}({classSymbol.Name} _) => _.As{param.Name};
");
            }

            foreach (var (param, arg, name) in paramArgsAndNames)
            {
                source.Append($@"
                    {RoslynFactory.CreatePropertyIsX(param, arg, name)}
                    {RoslynFactory.CreatePropertyAsX(param, arg, name)}
                    {RoslynFactory.CreateMethodTryPickX(paramArgPairs, param, arg, name)}
            ");
            }
            source.Append(@"    }
}");
            return source.ToString();
        }

        public void Initialize(GeneratorInitializationContext context)
            => context.RegisterForSyntaxNotifications(() => new OneOfSyntaxReceiver());
    }

    internal class OneOfSyntaxReceiver : ISyntaxReceiver
    {
        public List<ClassDeclarationSyntax> CandidateClasses { get; } = new();

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            if (syntaxNode is ClassDeclarationSyntax { AttributeLists: { Count: > 0 } } classDeclarationSyntax
                && classDeclarationSyntax.Modifiers.Any(SyntaxKind.PartialKeyword))
            {
                CandidateClasses.Add(classDeclarationSyntax);
            }
        }
    }
}
