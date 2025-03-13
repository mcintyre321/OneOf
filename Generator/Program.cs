using System.IO;
using System.Text;
using static System.IO.Path;
using static System.Reflection.Assembly;
using static System.Linq.Enumerable;
using System;
using System.Collections.Generic;

var sourceRoot = GetFullPath(Combine(GetDirectoryName(GetExecutingAssembly().Location)!, @"..\..\..\.."));

for (var i = 1; i < 10; i++) {
    var output = GetContent(true, i);
    var outpath = Combine(sourceRoot, $"OneOf\\OneOfT{i - 1}.generated.cs");
    File.WriteAllText(outpath, output);

    var output2 = GetContent(false, i);
    var outpath2 = Combine(sourceRoot, $"OneOf\\OneOfBaseT{i - 1}.generated.cs");
    File.WriteAllText(outpath2, output2);
}

for (var i = 10; i < 33; i++) {
    var output3 = GetContent(true, i);
    var outpath3 = Combine(sourceRoot, $"OneOf.Extended\\OneOfT{i - 1}.generated.cs");
    File.WriteAllText(outpath3, output3);

    var output4 = GetContent(false, i);
    var outpath4 = Combine(sourceRoot, $"OneOf.Extended\\OneOfBaseT{i - 1}.generated.cs");
    File.WriteAllText(outpath4, output4);
}

string GetContent(bool isStruct, int i) {
    string RangeJoined(string delimiter, Func<int, string> selector) => Range(0, i).Joined(delimiter, selector);
    string IfStruct(string s, string s2 = "") => isStruct ? s : s2;

    var className = isStruct ? "OneOf" : "OneOfBase";
    var genericArgs = Range(0, i).Select(e => $"T{e}").ToList();
    var genericArg = genericArgs.Joined(", ");
    var sb = new StringBuilder();
    const string invalidIndexException = "throw InvalidIndexException(_index)";
    
    sb.Append(@$"#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;
using static OneOf.Functions;

namespace OneOf
{{
    public {IfStruct("readonly struct", "class")} {className}<{genericArg}> : IOneOf
    {{
        {RangeJoined(@"
        ", j => $"readonly T{j} _value{j}{IfStruct("", " = default!")};")}
        readonly int _index;

        {IfStruct( // constructor
        $@"OneOf(int index, {RangeJoined(", ", j => $"T{j} value{j} = default!")})
        {{
            _index = index;
            {RangeJoined(@"
            ", j => $"_value{j} = value{j};")}
        }}",
        $@"protected OneOfBase(OneOf<{genericArg}> input)
        {{
            _index = input.Index;
            switch (_index)
            {{
                {RangeJoined($@"
                ", j => $"case {j}: _value{j} = input.AsT{j}; break;")}
                default: {invalidIndexException};
            }}
        }}"
        )}

        public object? Value =>
            _index switch
            {{
                {RangeJoined(@"
                ", j => $"{j} => _value{j},")}
                _ => {invalidIndexException}
            }};

        public int Index => _index;

        {RangeJoined(@"
        ", j=> $"public bool IsT{j} => _index == {j};")}

        {RangeJoined(@"
        ", j => $@"public T{j} AsT{j} =>
            _index == {j} ?
                _value{j} :
                throw new InvalidOperationException($""Cannot return as T{j} as result is T{{_index}}"");")}

        {IfStruct(RangeJoined(@"
        ", j => $"public static implicit operator {className}<{genericArg}>(T{j} t) => new {className}<{genericArg}>({j}, value{j}: t);"))}

        public void Switch({RangeJoined(", ", e => $"Action<T{e}> f{e}")})
        {{
            {RangeJoined(@"
            ", j => @$"if (_index == {j} && f{j} != null)
            {{
                f{j}(_value{j});
                return;
            }}")}
            {invalidIndexException};
        }}

        public TResult Match<TResult>({RangeJoined(", ", e => $"Func<T{e}, TResult> f{e}")})
        {{
            {RangeJoined(@"
            ", j => $@"if (_index == {j} && f{j} != null)
            {{
                return f{j}(_value{j});
            }}")}
            {invalidIndexException};
        }}

        {IfStruct(genericArgs.Joined(@"
        ", bindToType => $@"public static OneOf<{genericArgs.Joined(", ")}> From{bindToType}({bindToType} input) => input;"))}

        {IfStruct(genericArgs.Joined(@"
            ", bindToType => {
            var resultArgsPrinted = genericArgs.Select(x => {
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
                {genericArgs.Joined(@"
                ", (x, k) =>
                    x == bindToType ?
                        $"{k} => mapFunc(As{x})," :
                        $"{k} => As{x},")}
                _ => {invalidIndexException}
            }};
        }}";
        }))}
");

    if (i > 1) {
        sb.AppendLine(
            RangeJoined(@"
        ", j => {
                var genericArgWithSkip = Range(0, i).ExceptSingle(j).Joined(", ", e => $"T{e}");
                var remainderType = i == 2 ? genericArgWithSkip : $"OneOf<{genericArgWithSkip}>";
                return $@"
#if NET
		public bool TryPickT{j}([NotNullWhen(true)] out T{j}? value, {(i == 2 ? "[NotNullWhen(false)] " : "")}out {remainderType}{(i == 2 ? "?" : "")} remainder)
#else
		public bool TryPickT{j}(out T{j}? value, out {remainderType}{(i == 2 ? "?" : "")} remainder)
#endif
		{{
			value = IsT{j} ? AsT{j} : default;
            remainder = _index switch
            {{
                {RangeJoined(@"
                ", k => 
                       k == j ?
                           $"{k} => default," :
                           $"{k} => AsT{k},")}
                _ => {invalidIndexException}
            }};
			return this.IsT{j};
		}}";
            })
        );
    }

    sb.AppendLine($@"
        bool Equals({className}<{genericArg}> other) =>
            _index == other._index &&
            _index switch
            {{
                {RangeJoined(@"
                ", j => @$"{j} => Equals(_value{j}, other._value{j}),")}
                _ => false
            }};

        public override bool Equals(object? obj)
        {{
            if (ReferenceEquals(null, obj))
            {{
                return false;
            }}

            {IfStruct(
            $"return obj is OneOf<{genericArg}> o && Equals(o);",
            $@"if (ReferenceEquals(this, obj)) {{
                    return true;
            }}

            return obj is OneOfBase<{genericArg}> o && Equals(o);"
            )}
        }}

        public override string ToString() =>
            _index switch {{
                {RangeJoined(@"
                ", j => $"{j} => FormatValue(_value{j}),")}
                _ => throw new InvalidOperationException(""Unexpected index, which indicates a problem in the OneOf codegen."")
            }};

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

    return sb.ToString();
}

internal static class Extensions {
    public static string Joined<T>(this IEnumerable<T> source, string delimiter, Func<T, string>? selector = null) {
        if (selector == null) { return string.Join(delimiter, source); }
        return string.Join(delimiter, source.Select(selector));
    }
    public static string Joined<T>(this IEnumerable<T> source, string delimiter, Func<T, int, string> selector) {
        return string.Join(delimiter, source.Select(selector));
    }
    public static IEnumerable<T> ExceptSingle<T>(this IEnumerable<T> source, T single) => source.Except(Repeat(single, 1));
}