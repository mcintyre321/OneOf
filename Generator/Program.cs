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
    string IfNotStruct(string s) => !isStruct ? s : "";

    var className = isStruct ? "OneOf" : "OneOfBase";
    var genericArgs = Range(0, i).Select(e => $"T{e}").ToList();
    var genericArg = genericArgs.Joined(", ");
    var sb = new StringBuilder();

    sb.Append(@$"using System;

namespace OneOf
{{
    public {IfStruct("struct", "class")} {className}<{genericArg}> : IOneOf
    {{
        {RangeJoined(@"
        ", j => $"readonly T{j} _value{j};")}
        readonly int _index;

        {IfStruct(
        $@"OneOf(int index, {RangeJoined(", ", j => $"T{j} value{j} = default")})
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
                default: throw new InvalidOperationException();
            }}
        }}"
        )}

        public object Value =>
            _index switch
            {{
                {RangeJoined(@"
                ", j => $"{j} => _value{j},")}
                _ => throw new InvalidOperationException()
            }};

        public int Index => _index;

        {RangeJoined(@"
        ", j => $@"public bool IsT{j} => _index == {j};

        public T{j} AsT{j}
        {{
            get
            {{
                if (_index != {j})
                {{
                    throw new InvalidOperationException($""Cannot return as T{j} as result is T{{_index}}"");
                }}
                return _value{j};
            }}
        }}
        {IfStruct(@$"
        public static implicit operator {className}<{genericArg}>(T{j} t) => new {className}<{genericArg}>({j}, value{j}: t);
        ", "")}")}
        public void Switch({RangeJoined(", ", e => $"Action<T{e}> f{e}")})
        {{
            {RangeJoined(@"
            ", j => @$"if (_index == {j} && f{j} != null)
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
        }}{IfStruct(
        $@"

        {genericArgs.Joined(@"

        ", bindToType => $@"public static OneOf<{genericArgs.Joined(", ")}> From{bindToType}({bindToType} input)
        {{
            return input;
        }}"
        )}")}
");

    if (isStruct) {
        foreach (var bindToType in genericArgs) {

            // TODO once we replace the call in Map from Match to inline code (per #72)
            //  we'll be able to remove this variable and fold the entire block into the format string
            var resultArgsPrinted = genericArgs.Select(x => {
                return x == bindToType ? "TResult" : x;
            }).Joined(", ");
            sb.Append($@"
        public OneOf<{resultArgsPrinted}> Map{bindToType}<TResult>(Func<{bindToType}, TResult> mapFunc)
        {{
            if(mapFunc == null)
            {{
                throw new ArgumentNullException(nameof(mapFunc));
            }}
            return Match<OneOf<{resultArgsPrinted}>>(
                {genericArgs.Joined(@",
                ", (x, k) =>
                    x == bindToType ?
                        $"input{k} => mapFunc(input{k})" :
                        $"input{k} => input{k}"
            )}
            );
        }}
        ");

        }
    }

    if (i > 1) {
        // TODO fold this into the format string after implementing #72
        for (var j = 0; j < i; j++) {
            var genericArgWithSkip = Range(0, i).ExceptSingle(j).Joined(", ", e => $"T{e}");
            var remainderType = i == 2 ? genericArgWithSkip : $"OneOf<{genericArgWithSkip}>";
            sb.AppendLine($@"
		public bool TryPickT{j}(out T{j} value, out {remainderType} remainder)
		{{
			value = this.IsT{j} ? this.AsT{j} : default(T{j});
			remainder = " + ((i == 2) ? ($"this.IsT{j} ? default({remainderType}) : this.As{remainderType};") : $@"this.IsT{j}
				? default(OneOf<{genericArgWithSkip}>) 
				: this.Match<{remainderType}>(" + RangeJoined(", ", k => $"t{k} =>" + (k == j ? "throw new InvalidOperationException()" : $"t{k}")) + $@");")
            + $@"
			return this.IsT{j};
		}}");
        }
    }

    sb.AppendLine($@"
        bool Equals({className}<{genericArg}> other)
        {{
            if (_index != other._index)
            {{
                return false;
            }}
            switch (_index)
            {{
                {RangeJoined(@"
                ", j => $"case {j}: return Equals(_value{j}, other._value{j});")}
                default: return false;
            }}
        }}

        public override bool Equals(object obj)
        {{
            if (ReferenceEquals(null, obj))
                return false;


            {IfStruct(
        $"return obj is {className}<{genericArg}> && Equals(({className}<{genericArg}>)obj);",
        $@"if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<{genericArg}>;
            return other != null && Equals(other);")}
        }}

        public override string ToString()
        {{
            {IfStruct(
        @"string FormatValue<T>(Type type, T value) => $""{type.FullName}: {value?.ToString()}"";",
        @"string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $""{type.FullName}: {value?.ToString()}"";")}
            switch(_index) {{
                {RangeJoined(@"
                ", j => $"case {j}: return FormatValue(typeof(T{j}), _value{j});")}
                default: throw new InvalidOperationException(""Unexpected index, which indicates a problem in the OneOf codegen."");
            }}
        }}

        public override int GetHashCode()
        {{
            unchecked
            {{
                int hashCode;
                switch (_index)
                {{
                    {RangeJoined(@"
                    ", j => @$"case {j}:
                    hashCode = _value{j}?.GetHashCode() ?? 0;
                    break;")}
                    default:
                        hashCode = 0;
                        break;
                }}
                return (hashCode*397) ^ _index;
            }}
        }}
    }}
}}");

    return sb.ToString();
}

public static class Extensions {
    public static string Joined<T>(this IEnumerable<T> source, string delimiter, Func<T, string>? selector = null) {
        if (source == null) { return ""; }
        if (selector == null) { return string.Join(delimiter, source); }
        return string.Join(delimiter, source.Select(selector));
    }
    public static string Joined<T>(this IEnumerable<T> source, string delimiter, Func<T, int, string> selector) {
        if (source == null) { return ""; }
        return string.Join(delimiter, source.Select(selector));
    }
    public static IEnumerable<T> ExceptSingle<T>(this IEnumerable<T> source, T single) => source.Except(Repeat(single, 1));
    public static void AppendLineTo(this string? s, StringBuilder sb) => sb.AppendLine(s);
}