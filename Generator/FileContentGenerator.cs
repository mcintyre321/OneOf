using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Generator;

public sealed class FileContentGenerator : IDisposable
{
    private delegate void ReadOnlySpanAction<T>(ReadOnlySpan<T> obj);
    
    private readonly bool _isStruct;
    private readonly int _index;
    private readonly StreamWriter _streamWriter;
    private readonly string _className;
    private readonly List<string> _genericArgs;
    private readonly string _genericArg;

    public FileContentGenerator(string path, bool isStruct, int index)
    {
        _isStruct = isStruct;
        _index = index;
        _streamWriter = new StreamWriter(path);
        
        _className = _isStruct ? "OneOf" : "OneOfBase";
        _genericArgs = Enumerable.Range(0, _index).Select(e => $"T{e}").ToList();
        _genericArg = _genericArgs.Joined(", ");
    }

    private string RangeJoined(string delimiter, Func<int, string> selector) =>
        Enumerable.Range(0, _index).Joined(delimiter, selector);

    private string IfStruct(string s, string s2 = "") => _isStruct ? s : s2;
    
    private static void ForEachCombination(
        ReadOnlySpan<string> src, int k, ReadOnlySpanAction<int> action)
    {
        int n = src.Length;
        if (k < 0 || k > n)
        {
            return;
        }

        // --- стековые буферы ---
        Span<int> idx = k <= 64 ? stackalloc int[k] : new int[k];

        // инициализируем первую комбинацию 0..k-1
        for (int j = 0; j < k; j++)
        {
            idx[j] = j;
        }

        while (true)
        {
            action(idx); // ← обрабатываем без аллокации

            // переходим к следующей комбинации
            int i = k - 1;
            while (i >= 0 && idx[i] == n - k + i)
            {
                i--;
            }

            if (i < 0)
            {
                break; // перебрали всё
            }

            idx[i]++;
            for (int j = i + 1; j < k; j++)
            {
                idx[j] = idx[j - 1] + 1;
            }
        }
    }

    public void WriteContent()
    {
        _streamWriter.Write($@"using System;
using static OneOf.Functions;

namespace OneOf
{{");
        _streamWriter.Write(@$"
    public {IfStruct("readonly struct", "class")} {_className}<{_genericArg}> : IOneOf
    {{");
        
        _streamWriter.WriteLine($@"
        {RangeJoined(@"
        ", j => $"readonly T{j} _value{j};")}
        readonly int _index;");
        
        _streamWriter.WriteLine(@$"
        {IfStruct( // constructor
            $@"OneOf(int index, {RangeJoined(", ", j => $"T{j} value{j} = default")})
        {{
            _index = index;
            {RangeJoined(@"
            ", j => $"_value{j} = value{j};")}
        }}",
            $@"protected OneOfBase(OneOf<{_genericArg}> input)
        {{
            _index = input.Index;
            switch (_index)
            {{
                {RangeJoined($@"
                ", j => $"case {j}: _value{j} = input.AsT{j}; break;")}
                default: throw new InvalidOperationException();
            }}
        }}")}");

        _streamWriter.WriteLine($@"
        public object Value =>
            _index switch
            {{
                {RangeJoined(@"
                ", j => $"{j} => _value{j},")}
                _ => throw new InvalidOperationException()
            }};

        public int Index => _index;");
        
        _streamWriter.WriteLine(@$"
        {RangeJoined(@"
        ", j => $"public bool IsT{j} => _index == {j};")}");
        
        _streamWriter.WriteLine(@$"
        {RangeJoined(@"
        ", j => $@"public T{j} AsT{j} =>
            _index == {j} ?
                _value{j} :
                throw new InvalidOperationException($""Cannot return as T{j} as result is T{{_index}}"");")}");
        
        _streamWriter.WriteLine(@$"
        {IfStruct(RangeJoined(@"
        ", j => $"public static implicit operator {_className}<{_genericArg}>(T{j} t) => new {_className}<{_genericArg}>({j}, value{j}: t);"))}");
        
        if (_isStruct && _index > 1 && _index < 10)
        {
            for (int i = 2; i < _genericArgs.Count; i++)
            {
                ForEachCombination(CollectionsMarshal.AsSpan(_genericArgs), i, idx =>
                {
                    _streamWriter.Write($"        public static implicit operator {_className}<{_genericArg}>({_className}<");
                    for (int j = 0; j < idx.Length; j++)
                    {
                        if (j != 0)
                        {
                            _streamWriter.Write(", ");
                        }
                        
                        _streamWriter.Write(_genericArgs[idx[j]]);
                    }

                    _streamWriter.Write($"> subset) => subset.Match<{_className}<{_genericArg}>>(");
                    
                    for (int j = 0; j < idx.Length; j++)
                    {
                        if (j != 0)
                        {
                            _streamWriter.Write(", ");
                        }
                        
                        _streamWriter.Write("x => x");
                    }

                    _streamWriter.WriteLine(");");
                });
            }
        }
        
        _streamWriter.WriteLine($@"
        public void Switch({RangeJoined(", ", e => $"Action<T{e}> f{e}")})
        {{
            {RangeJoined(@"
            ", j => @$"if (_index == {j} && f{j} != null)
            {{
                f{j}(_value{j});
                return;
            }}")}
            throw new InvalidOperationException();
        }}");
        
        _streamWriter.WriteLine($@"
        public TResult Match<TResult>({RangeJoined(", ", e => $"Func<T{e}, TResult> f{e}")})
        {{
            {RangeJoined(@"
            ", j => $@"if (_index == {j} && f{j} != null)
            {{
                return f{j}(_value{j});
            }}")}
            throw new InvalidOperationException();
        }}");

        _streamWriter.WriteLine($@"
        {IfStruct(_genericArgs.Joined(@"
        ", bindToType => $@"public static OneOf<{_genericArgs.Joined(", ")}> From{bindToType}({bindToType} input) => input;"))}");
        
        _streamWriter.WriteLine($@"
        {IfStruct(_genericArgs.Joined(@"
            ", bindToType => {
            var resultArgsPrinted = _genericArgs.Select(x => {
                return x == bindToType ? "TResult" : x;
            }).Joined(", ");
            return $@"
        public OneOf<{resultArgsPrinted}> Map{bindToType}<TResult>(Func<{bindToType}, TResult> mapFunc)
        {{
            if (mapFunc == null)
            {{
                throw new ArgumentNullException(nameof(mapFunc));
            }}
            return _index switch
            {{
                {_genericArgs.Joined(@"
                ", (x, k) =>
                    x == bindToType ?
                        $"{k} => mapFunc(As{x})," :
                        $"{k} => As{x},")}
                _ => throw new InvalidOperationException()
            }};
        }}";
        }))}");

        if (_index > 1)
        {
            _streamWriter.WriteLine(RangeJoined(@"
        ", j =>
            {
                var genericArgWithSkip = Enumerable.Range(0, _index).ExceptSingle(j).Joined(", ", e => $"T{e}");
                var remainderType = _index == 2 ? genericArgWithSkip : $"OneOf<{genericArgWithSkip}>";
                return $@"
		public bool TryPickT{j}(out T{j} value, out {remainderType} remainder)
		{{
			value = IsT{j} ? AsT{j} : default;
            remainder = _index switch
            {{
                {RangeJoined(@"
                ", k =>
                    k == j ?
                        $"{k} => default," :
                        $"{k} => AsT{k},")}
                _ => throw new InvalidOperationException()
            }};
			return this.IsT{j};
		}}";
            }));
        }
        
        _streamWriter.WriteLine($@"
        bool Equals({_className}<{_genericArg}> other) =>
            _index == other._index &&
            _index switch
            {{
                {RangeJoined(@"
                ", j => @$"{j} => Equals(_value{j}, other._value{j}),")}
                _ => false
            }};");
        
        _streamWriter.WriteLine($@"
        public override bool Equals(object obj)
        {{
            if (ReferenceEquals(null, obj))
            {{
                return false;
            }}

            {IfStruct(
                $"return obj is OneOf<{_genericArg}> o && Equals(o);",
                $@"if (ReferenceEquals(this, obj)) {{
                    return true;
            }}

            return obj is OneOfBase<{_genericArg}> o && Equals(o);"
            )}
        }}");
        
        _streamWriter.WriteLine($@"
        public override string ToString() =>
            _index switch {{
                {RangeJoined(@"
                ", j => $"{j} => FormatValue(_value{j}),")}
                _ => throw new InvalidOperationException(""Unexpected index, which indicates a problem in the OneOf codegen."")
            }};");
        
        _streamWriter.WriteLine($@"
        public override int GetHashCode()
        {{
            unchecked
            {{
                int hashCode = _index switch
                {{
                    {RangeJoined(@"
                    ", j => $"{j} => _value{j}?.GetHashCode(),")}
                    _ => 0
                }} ?? 0;
                return (hashCode*397) ^ _index;
            }}
        }}
    }}
}}");
    }

    public void Dispose()
    {
        _streamWriter.Dispose();
    }
}
