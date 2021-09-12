using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using OneOf.Extensions;
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
            AttributeData attributeData)
        {
            var diagnostics = new List<Diagnostic>();

            var attributeLocation = attributeData.GetSyntax()?.GetLocation();

            if (!classSymbol.ContainingSymbol.Equals(classSymbol.ContainingNamespace, SymbolEqualityComparer.Default))
                diagnostics.Add(Diagnostic.Create(DiagnosticErrors.TopLevelError, attributeLocation, classSymbol.Name));

            if (classSymbol.BaseType is null || classSymbol.BaseType.Name != "OneOfBase" || classSymbol.BaseType.ContainingNamespace.ToString() != "OneOf")
                diagnostics.Add(Diagnostic.Create(DiagnosticErrors.WrongBaseType, attributeLocation, classSymbol.Name));

            if (classSymbol.DeclaredAccessibility != Accessibility.Public)
                diagnostics.Add(Diagnostic.Create(DiagnosticErrors.ClassIsNotPublic, attributeLocation, classSymbol.Name));

            return diagnostics.ReportIfAny(context);
        }

        public static bool ValidateTypeArguments(
            this GeneratorExecutionContext context,
            ITypeSymbol classSymbol,
            AttributeData attributeData)
        {
            var diagnostics = new List<Diagnostic>();

            var typeArguments = classSymbol.BaseType.TypeArguments;

            if (typeArguments.Any(x => x.Name == nameof(Object)))
            {
                var attributeLocation = attributeData.GetSyntax()?.GetLocation();
                diagnostics.Add(Diagnostic.Create(DiagnosticErrors.ObjectIsOneOfType, attributeLocation, classSymbol.Name));
            }
            return diagnostics.ReportIfAny(context);
        }

        public static bool ValidateTypeNames(
            this GeneratorExecutionContext context,
            ITypeSymbol classSymbol,
            AttributeData attributeData)
        {
            var diagnostics = new List<Diagnostic>();

            var typeArguments = classSymbol.BaseType.TypeArguments;
            var attributeSyntax = attributeData.GetSyntax();
            var attributeLocation = attributeSyntax?.GetLocation();

            var typeNames = attributeData.ConstructorArguments.First().Values;
            if (typeNames.Length > 0 && typeNames.Length != typeArguments.Length)
                diagnostics.Add(Diagnostic.Create(DiagnosticErrors.WrongNumberOfTypeNames, attributeLocation, typeArguments.Length, typeNames.Length));

            var typeNameSyntaxes = attributeSyntax.ArgumentList?.Arguments
                .Where(x => x.NameEquals == null)
                .Select(x => x.Expression.GetLocation())
                .ToArray();

            foreach (var (name, nameIndex) in typeNames.Select((x, i) => (x, i)))
            {
                var location = nameIndex < typeNameSyntaxes.Length
                    ? typeNameSyntaxes[nameIndex]
                    : attributeLocation;
                if (string.IsNullOrEmpty(name.Value as string))
                    diagnostics.Add(Diagnostic.Create(DiagnosticErrors.TypeNameCannotBeNullOrEmpty, attributeLocation, nameIndex + 1));

                if (!SyntaxFacts.IsValidIdentifier("_" + name.Value))
                    diagnostics.Add(Diagnostic.Create(DiagnosticErrors.InvalidTypeName, attributeLocation, name.Value));
            }

            return diagnostics.ReportIfAny(context);
        }
    }
}
