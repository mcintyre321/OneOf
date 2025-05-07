using Generator;
using static System.IO.Path;
using static System.Reflection.Assembly;

var sourceRoot = GetFullPath(Combine(GetDirectoryName(GetExecutingAssembly().Location)!, @"..\..\..\.."));

for (var i = 1; i < 10; i++)
{
    using (var contentGenerator =
        new FileContentGenerator(Combine(sourceRoot, $"OneOf\\OneOfT{i - 1}.generated.cs"), true, i))
    {
        contentGenerator.WriteContent();
    }

    using (var contentGenerator =
        new FileContentGenerator(Combine(sourceRoot, $"OneOf\\OneOfBaseT{i - 1}.generated.cs"), false, i))
    {
        contentGenerator.WriteContent();
    }
}

for (var i = 10; i < 33; i++)
{
    using (var contentGenerator =
        new FileContentGenerator(Combine(sourceRoot, $"OneOf.Extended\\OneOfT{i - 1}.generated.cs"), true, i))
    {
        contentGenerator.WriteContent();
    }

    using (var contentGenerator =
        new FileContentGenerator(Combine(sourceRoot, $"OneOf.Extended\\OneOfBaseT{i - 1}.generated.cs"), false, i))
    {
        contentGenerator.WriteContent();
    }
}
