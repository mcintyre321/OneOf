using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using OneOf.SourceGenerator;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace OneOf
{
    internal static class Validator
    {
        public static bool ValidateClass(
            this GeneratorExecutionContext context,
            ITypeSymbol classSymbol,
            Location attributeLocation)
        {
            var diagnostics = new List<Diagnostic>();

            if (!classSymbol.ContainingSymbol.Equals(classSymbol.ContainingNamespace, SymbolEqualityComparer.Default))
                diagnostics.Add(Diagnostic.Create(DiagnosticErrors.TopLevelError, attributeLocation, classSymbol.Name));

            if (classSymbol.BaseType is null || classSymbol.BaseType.Name != "OneOfBase" || classSymbol.BaseType.ContainingNamespace.ToString() != "OneOf")
                diagnostics.Add(Diagnostic.Create(DiagnosticErrors.WrongBaseType, attributeLocation, classSymbol.Name));

            if (classSymbol.DeclaredAccessibility != Accessibility.Public)
                diagnostics.Add(Diagnostic.Create(DiagnosticErrors.ClassIsNotPublic, attributeLocation, classSymbol.Name));

            return diagnostics.ReportAndFailIfAny(context);
        }


        public static bool ValidateTypeArguments(
            this GeneratorExecutionContext context,
            ITypeSymbol classSymbol,
            Location attributeLocation,
            IReadOnlyCollection<ITypeSymbol> typeArguments)
        {
            var diagnostics = new List<Diagnostic>();

            if (typeArguments.Any(x => x.Name == nameof(Object)))
            {
                diagnostics.Add(Diagnostic.Create(DiagnosticErrors.ObjectIsOneOfType, attributeLocation, classSymbol.Name));
            }
            return diagnostics.ReportAndFailIfAny(context);
        }

        public static bool ValidateTypeNames(
            this GeneratorExecutionContext context,
            ITypeSymbol classSymbol,
            Location attributeLocation,
            IReadOnlyCollection<ITypeSymbol> typeArguments,
            IReadOnlyCollection<TypedConstant> typeNames)
        {
            var diagnostics = new List<Diagnostic>();

            if (typeNames.Count > 0 && typeNames.Count != typeArguments.Count)
                diagnostics.Add(Diagnostic.Create(DiagnosticErrors.WrongNumberOfTypeNames, attributeLocation, typeArguments.Count, typeNames.Count));

            foreach (var (name, nameIndex) in typeNames.Select((x, i) => (x, i)))
            {
                if (string.IsNullOrEmpty(name.Value as string))
                    diagnostics.Add(Diagnostic.Create(DiagnosticErrors.TypeNameCannotBeNullOrEmpty, attributeLocation, nameIndex + 1));

                if (!SyntaxFacts.IsValidIdentifier("_" + name.Value))
                    diagnostics.Add(Diagnostic.Create(DiagnosticErrors.InvalidTypeName, attributeLocation, name.Value));

            }

            return diagnostics.ReportAndFailIfAny(context);
        }



        private static bool ReportAndFailIfAny(this IEnumerable<Diagnostic> diagnostics, GeneratorExecutionContext context)
        {
            if (diagnostics.Any())
            {
                foreach (var diag in diagnostics)
                    context.ReportDiagnostic(diag);

                return false;
            }

            return true;
        }
    }
}
