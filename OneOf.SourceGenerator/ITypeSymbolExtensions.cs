using Microsoft.CodeAnalysis;

namespace OneOf.SourceGenerator
{
    public static class ITypeSymbolExtensions
    {
        public static string GetFullName(this ITypeSymbol type) => $"{(type.ContainingNamespace is object ? $"{type.ContainingNamespace}." : string.Empty)}{type.Name}";
    }
}
