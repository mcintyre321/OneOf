
using BenchmarkDotNet.Attributes;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using OneOf.SourceGenerator;
using System.Reflection;

namespace OneOf.Benchmarks;

[MemoryDiagnoser]
[InProcess]
[HtmlExporter]
[JsonExporterAttribute.Full]
public class SourceGeneratorBenchmarks
{
    private const string Small =
        """
        using OneOf;

        namespace Foo
        {
            [GenerateOneOf]
            public partial class Option : OneOfBase<int, string> { }
        }
        """;
    
    private const string Large =
        """
        using OneOf;

        namespace Foo
        {
            [GenerateOneOf]
            public partial class Option : OneOfBase<int, string> { }

            [GenerateOneOf]
            public partial class NestedGeneric : OneOfBase<List<List<string>>, List<int>, Dictionary<List<string>, string>> { }

            [GenerateOneOf]
            public partial class SimpleGeneric : OneOfBase<List<string>, List<int>, Dictionary<long, string>> { }

            [GenerateOneOf]
            internal partial class StringOrNumber : OneOfBase<string, int, uint> { }
        }
        """;
    
    private GeneratorDriver? _driver;
    private Compilation? _compilation;

    private static CSharpCompilation BuildCompilation(params SyntaxTree[] syntaxTrees)
    {
        var references = new List<MetadataReference>
        {
            MetadataReference.CreateFromFile(typeof(Binder).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(OneOfBase<>).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(AppDomain.CurrentDomain.GetAssemblies().Single(a => a.GetName().Name == "netstandard").Location)
        };

        //https://github.com/dotnet/roslyn/issues/49498#issuecomment-734452762
        foreach (var assembly in Assembly.GetEntryAssembly()!.GetReferencedAssemblies())
        {
            references.Add(MetadataReference.CreateFromFile(Assembly.Load(assembly).Location));
        }

        var compilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary);

        return CSharpCompilation.Create("Benchmark", syntaxTrees, references, compilationOptions);
    }

    private void BuildGenerator(string source)
    {
        var syntaxTree = CSharpSyntaxTree.ParseText(source, CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.Default));
        _compilation = BuildCompilation(syntaxTree);

        var generator = new OneOfGenerator();
        _driver = CSharpGeneratorDriver.Create(generator);
    }
    
    private void BuildIncremental(string source)
    {
        BuildGenerator(source);
        _driver = _driver!.RunGeneratorsAndUpdateCompilation(_compilation!, out _, out _);
    }

    [GlobalSetup(Target = nameof(SmallCompile))]
    public void SetupSmall() =>  BuildGenerator(Small);

    [GlobalSetup(Target = nameof(LargeCompile))]
    public void SetupLarge() =>  BuildGenerator(Large);
    
    [GlobalSetup(Target = nameof(SmallCompileIncremental))]
    public void SetupSmallIncremental() =>  BuildIncremental(Small);

    [GlobalSetup(Target = nameof(LargeCompileIncremental))]
    public void SetupLargeIncremental() =>  BuildIncremental(Large);

    [Benchmark]
    public GeneratorDriver SmallCompile() => _driver!.RunGeneratorsAndUpdateCompilation(_compilation!, out _, out _);

    [Benchmark]
    public GeneratorDriver LargeCompile() => _driver!.RunGeneratorsAndUpdateCompilation(_compilation!, out _, out _);
    
    [Benchmark]
    public GeneratorDriver SmallCompileIncremental() => _driver!.RunGeneratorsAndUpdateCompilation(_compilation!, out _, out _);

    [Benchmark]
    public GeneratorDriver LargeCompileIncremental() => _driver!.RunGeneratorsAndUpdateCompilation(_compilation!, out _, out _);
}
