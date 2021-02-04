using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using static System.Linq.Enumerable;

// the generator exe is in 'bin/$config/$tfm
var sourceRoot =  Path.GetFullPath(Path.Combine(Assembly.GetExecutingAssembly().Location, @"..\..\..\..\.."));

var output = GetContent(true, 1, 10);
var outpath = Path.Combine(sourceRoot, @"OneOf\OneOf.cs");
File.WriteAllText(outpath, output);

var output2 = GetContent(false, 1, 10);
var outpath2 = Path.Combine(sourceRoot, @"OneOf\OneOfBase.cs");
File.WriteAllText(outpath2, output2);

var output3 = GetContent(true, 10, 33);
var outpath3 = Path.Combine(sourceRoot, @"OneOf.Extended\OneOf.cs");
File.WriteAllText(outpath3, output3);

var output4 = GetContent(false, 10, 33);
var outpath4 = Path.Combine(sourceRoot, @"OneOf.Extended\OneOfBase.cs");
File.WriteAllText(outpath4, output4);


string GetContent(bool isStruct, int indexStart, int indexEnd) {
    var className = isStruct ? "OneOf" : "OneOfBase";
    var sb = new StringBuilder();
    sb.Append($@"using System;
{(isStruct ? @"
using static OneOf.Functions;" : "")}

namespace OneOf
{{");

    for (var i = indexStart; i < indexEnd; i++) {
        string RangeJoined(string delimiter, Func<int, string> selector) => Range(0,i).Joined(delimiter,selector);

        var genericArg = RangeJoined(", ", e => $"T{e}");

        $@"
    public {(isStruct ? "struct" : "class")} {className}<{genericArg}> : IOneOf
    {{
        {RangeJoined(@"
        ", j => $"readonly T{j} _value{j};")}
        readonly int _index;

        {If(isStruct, 
            $@"{className}(int index, {RangeJoined(", ", j => $"T{j} value{j} = default")})
        {{
            _index = index;
            {RangeJoined(@"
            ", j => $"_value{j} = value{j};")}
        }}"
        )}{If(!isStruct,
            $@"protected {className}(OneOf<{genericArg}> input)
        {{
            _index = input.Index;
            switch (_index)
            {{
                {RangeJoined($@"
                ", j => $"case {j}: _value{j} = input.AsT{j}; break;")}
                default: throw new InvalidOperationException();
            }}
        }}"
        )}

        public object Value => _index switch
        {{
            {RangeJoined(@"
            ", k => $"{k} => _value{k},")}
            _ => throw new InvalidOperationException()
        }};
        
        public int Index => _index;

        {RangeJoined(@"
        ", j => $@"public bool IsT{j} => _index == {j};
        
        public T{j} AsT{j} =>
            _index == {j} ?
                _value{j} :
                throw new NotImplementedException($""Cannot return as T{j} as result is T{{_index}}"");

        {If(isStruct,
        @$"public static implicit operator {className}<{genericArg}>(T{j} t) => new {className}<{genericArg}>({j}, value{j}: t);
"
        )}"
        )}

        public void Switch({RangeJoined(", ", e => $"Action<T{e}> f{e}")})
        {{
            {RangeJoined(@"
            ", j => $@"if (_index == {j} && f{j} != null)
            {{
                f{j}(_value{j});
                return;
            }}")}
            throw new InvalidOperationException();
        }}

        public TResult Match<TResult>({RangeJoined(", ", e => $"Func<T{e}, TResult> f{e}")})
        {{
            {RangeJoined(@"
            ", j => $@"if (_index == {j} && f{j} != null)
            {{
                return f{j}(_value{j});
            }}")}
            throw new InvalidOperationException();
        }}".AppendLineTo(sb);

        if (isStruct) {
            var genericArgs = Range(0, i).Select(e => $"T{e}").ToList();

            sb.AppendLine(RangeJoined("", j => @$"
        public static OneOf<{genericArgs.Joined(", ")}> FromT{j}(T{j} input) => input;"));

            foreach (var bindToType in genericArgs) {

                var resultArgs = genericArgs.Select(x => x == bindToType ? "TResult" : x).ToList();
                sb.Append($@"
        public OneOf<{resultArgs.Joined(", ")}> Map{bindToType}<TResult>(Func<{bindToType}, TResult> mapFunc)
        {{");
                sb.Append($@"
            if (mapFunc == null)
            {{
                throw new ArgumentNullException(nameof(mapFunc));
            }}
            return _index switch
            {{
                {RangeJoined(@"
                ", k => {
                    var arg =
                        bindToType != $"T{k}" ?
                            $"AsT{k}" :
                            $"mapFunc(AsT{k})";
                    return $"{k} => {arg},";
                })}
                _ => throw new InvalidOperationException()
            }};
        }}");
            }

        }

        if (i > 1) {
            for (var j = 0; j < i; j++) {

                var genericArgWithSkip = Range(0, i).Except(new[] { j }).Joined(", ", e => $"T{e}");
                var remainderType = i == 2 ? genericArgWithSkip : $"OneOf<{genericArgWithSkip}>";
                sb.AppendLine($@"
		public bool TryPickT{j}(out T{j} value, out {remainderType} remainder)
		{{
            value = IsT{j} ? AsT{j} : default;
            remainder = _index switch
            {{
                {RangeJoined(@"
                ", k => {
                    var result =
                        k == j ? "default" :
                        i == 2 ? $"AsT{k}" :
                        k < j ? $"{remainderType}.FromT{k}(AsT{k})" :
                        $"{remainderType}.FromT{k - 1}(AsT{k})";
                    return $"{k} => {result},";
                })}
                _ => throw new InvalidOperationException()
            }};
            return IsT{j};
		}}");
            }
        }

        $@"
        bool Equals({className}<{genericArg}> other) =>
            _index == other._index &&
            _index switch
            {{
                {RangeJoined("", j => @$"
                {j} => Equals(_value{j}, other._value{j}),")}
                _ => false
            }};

        {(
            isStruct ?
                $"public override bool Equals(object obj) => obj is {className}<{genericArg}> o && Equals(o);" :
                @$"public override bool Equals(object obj)
        {{
            if (ReferenceEquals(null, obj))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            return obj is {className}<{genericArg}> o && Equals(o);
        }}"
        )}

        public override string ToString()
        {{{(isStruct ? "" : @"
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $""{type.FullName}: {value?.ToString()}"";")}
            return _index switch
            {{
                {RangeJoined(@"
                ", j => $"{j} => FormatValue(typeof(T{j}), _value{j}),")}
                _ => throw new InvalidOperationException(""Unexpected index, which indicates a problem in the OneOf codegen."")
            }};
        }}

        public override int GetHashCode()
        {{
            int hashCode = _index switch
            {{
                {RangeJoined(@"
                ", j => $"{j} => _value{j}?.GetHashCode() ?? 0,")}
                _ => 0
            }};
            return (hashCode*397) ^ _index;
        }}
    }}".AppendLineTo(sb);
    }
    sb.AppendLine("}");
    return sb.ToString(); ;
}

string If(bool test, string s) =>
    test ?
        s :
        "";

public static class Extensions {
    public static string Joined<T>(this IEnumerable<T> source, string delimiter, Func<T, string>? selector = null) {
        if (source == null) { return ""; }
        if (selector == null) { return string.Join(delimiter, source); }
        return string.Join(delimiter, source.Select(selector));
    }
    public static void AppendTo(this string? s, StringBuilder sb) => sb.Append(s);
    public static void AppendLineTo(this string? s, StringBuilder sb) => sb.AppendLine(s);
}