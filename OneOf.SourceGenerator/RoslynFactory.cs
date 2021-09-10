using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace OneOf.SourceGenerator
{
    internal class RoslynFactory
    {
        internal static PropertyDeclarationSyntax CreatePropertyIsX(ITypeParameterSymbol param, ITypeSymbol arg, TypedConstant name)
        {
            throw new NotImplementedException();
        }

        internal static PropertyDeclarationSyntax CreatePropertyAsX(ITypeParameterSymbol param, ITypeSymbol arg, TypedConstant name)
        {
            throw new NotImplementedException();
        }

        internal static MethodDeclarationSyntax CreateMethodTryPickX(ITypeParameterSymbol param, ITypeSymbol arg, TypedConstant name)
        {
            throw new NotImplementedException();
        }
    }
}