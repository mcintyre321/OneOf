using SourceGenerator.Tests;

// ReSharper disable once CheckNamespace
namespace OneOf.SourceGenerator.Tests;

[GenerateOneOf]
public partial class ConflictingNamespaceTypes : OneOfBase<ConflictingNamespaceType1, ConflictingNamespaceType2>
{
}