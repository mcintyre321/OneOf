using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneOf.Extensions
{
    internal static class SymbolsExtensions
    {
        public static AttributeSyntax GetSyntax(this AttributeData attributeData)
        {
            return attributeData.ApplicationSyntaxReference?.GetSyntax() as AttributeSyntax;
        }
    }
}
