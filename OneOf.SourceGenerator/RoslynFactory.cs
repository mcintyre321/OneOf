using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OneOf.SourceGenerator
{
    internal class RoslynFactory
    {
        internal static PropertyDeclarationSyntax CreatePropertyIsX(ITypeParameterSymbol param, ITypeSymbol arg, TypedConstant name)
        {
            return SyntaxFactory.PropertyDeclaration(
                    SyntaxFactory.PredefinedType(
                        SyntaxFactory.Token(SyntaxKind.BoolKeyword)),
                    SyntaxFactory.Identifier("Is" + name.Value))
                .WithModifiers(
                    SyntaxFactory.TokenList(
                        SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                .WithExpressionBody(
                    SyntaxFactory.ArrowExpressionClause(
                        SyntaxFactory.MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            SyntaxFactory.ThisExpression(),
                            SyntaxFactory.IdentifierName("Is" + param.Name))))
                .WithSemicolonToken(
                    SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                .NormalizeWhitespace();
        }

        internal static PropertyDeclarationSyntax CreatePropertyAsX(ITypeParameterSymbol param, ITypeSymbol arg, TypedConstant name)
        {
            return SyntaxFactory.PropertyDeclaration(
                    SyntaxFactory.IdentifierName(arg.ToDisplayString()),
                    SyntaxFactory.Identifier("As" + name.Value))
                .WithModifiers(
                    SyntaxFactory.TokenList(
                        SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                .WithExpressionBody(
                    SyntaxFactory.ArrowExpressionClause(
                        SyntaxFactory.MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            SyntaxFactory.ThisExpression(),
                            SyntaxFactory.IdentifierName("As" + param.Name))))
                .WithSemicolonToken(
                    SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                .NormalizeWhitespace();
        }

        internal static MethodDeclarationSyntax CreateMethodTryPickX(
            IEnumerable<(ITypeParameterSymbol param, ITypeSymbol arg)> paramArgPairs,
            ITypeParameterSymbol param, ITypeSymbol arg, TypedConstant name)
        {
            var remainderArgs = paramArgPairs
                .Except(new[] { (param, arg) })
                .Select(x => x.arg.ToDisplayString())
                .Select(x => SyntaxFactory.IdentifierName(x))
                .ToArray();
            TypeSyntax remainderType = remainderArgs.Count() > 1
                ? SyntaxFactory.GenericName(SyntaxFactory.Identifier("OneOf"))
                    .WithTypeArgumentList(SyntaxFactory.TypeArgumentList(
                        SyntaxFactory.SeparatedList<TypeSyntax>(remainderArgs)))
                : remainderArgs.Single();

            return SyntaxFactory.MethodDeclaration(
                    SyntaxFactory.PredefinedType(
                        SyntaxFactory.Token(SyntaxKind.BoolKeyword)),
                    SyntaxFactory.Identifier("TryPick" + name.Value))
                .WithModifiers(
                    SyntaxFactory.TokenList(
                        SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                .WithParameterList(
                    SyntaxFactory.ParameterList(
                        SyntaxFactory.SeparatedList<ParameterSyntax>(
                            new SyntaxNodeOrToken[]{
                                SyntaxFactory.Parameter(SyntaxFactory.Identifier("value"))
                                    .WithModifiers(
                                        SyntaxFactory.TokenList(
                                            SyntaxFactory.Token(SyntaxKind.OutKeyword)))
                                    .WithType(SyntaxFactory.IdentifierName(arg.ToDisplayString())),
                                SyntaxFactory.Token(SyntaxKind.CommaToken),
                                SyntaxFactory.Parameter(SyntaxFactory.Identifier("remainder"))
                                    .WithModifiers(
                                        SyntaxFactory.TokenList(
                                            SyntaxFactory.Token(SyntaxKind.OutKeyword)))
                                    .WithType(remainderType)})))
                .WithExpressionBody(
                    SyntaxFactory.ArrowExpressionClause(
                        SyntaxFactory.InvocationExpression(
                            SyntaxFactory.MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                SyntaxFactory.ThisExpression(),
                                SyntaxFactory.IdentifierName("TryPick" + param.Name)))
                        .WithArgumentList(
                            SyntaxFactory.ArgumentList(
                                SyntaxFactory.SeparatedList<ArgumentSyntax>(
                                    new SyntaxNodeOrToken[]{
                            SyntaxFactory.Argument(
                                SyntaxFactory.IdentifierName("value"))
                            .WithRefOrOutKeyword(
                                SyntaxFactory.Token(SyntaxKind.OutKeyword)),
                            SyntaxFactory.Token(SyntaxKind.CommaToken),
                            SyntaxFactory.Argument(SyntaxFactory.IdentifierName("remainder"))
                            .WithRefOrOutKeyword(
                                SyntaxFactory.Token(SyntaxKind.OutKeyword))})))))
                .WithSemicolonToken(
                    SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                .NormalizeWhitespace();
        }
    }
}