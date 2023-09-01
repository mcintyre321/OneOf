using SourceGenerator.Tests;

namespace OneOf.SourceGenerator.Tests;

[GenerateOneOf]
public partial class ConflictingNamespaceTypes : OneOfBase<ConflictingNamespaceType1, ConflictingNamespaceType2>
{
}