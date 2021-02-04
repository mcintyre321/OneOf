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
        var genericArg = Range(0, i).Joined(", ", e => $"T{e}");

        sb.AppendLine($@"
    public {(isStruct ? "struct" : "class")} {className}<{genericArg}> : IOneOf");
        sb.AppendLine("    {");
        for (var j = 0; j < i; j++) {
            sb.AppendLine($@"        readonly T{j} _value{j};");
        }

        sb.AppendLine($@"        readonly int _index;");

        if (isStruct) {
            sb.Append($@"
        {className}(int index");
            for (var j = 0; j < i; j++) {
                sb.Append($", T{j} value{j} = default");
            }
            sb.Append(@")
        {
            _index = index;");
            for (var j = 0; j < i; j++) {
                sb.Append($@"
            _value{j} = value{j};");
            }
            sb.AppendLine(@"
        }");
        }

        if (!isStruct) {
            sb.Append($@"
        protected {className}(OneOf<{genericArg}> input)
        {{
            _index = input.Index;
            switch (_index)
            {{");
            for (var j = 0; j < i; j++) {
                sb.Append(@$"
                case {j}: _value{j} = input.AsT{j}; break;");
            }
            sb.Append($@"
                default: throw new InvalidOperationException();
            }}
        }}
        ");
        }

        sb.Append($@"
        public object Value => _index switch
        {{
            {Range(0, i).Joined(@"
            ", k => $"{k} => _value{k},")}
            _ => throw new InvalidOperationException()
        }};
        
        public int Index => _index;
        ");

        sb.AppendLine(Range(0, i).Joined("", j => $@"
        public bool IsT{j} => _index == {j};
        
        public T{j} AsT{j} =>
            _index == {j} ?
                _value{j} :
                throw new NotImplementedException($""Cannot return as T{j} as result is T{{_index}}"");
        {(
            isStruct ? $@"
        public static implicit operator {className}<{genericArg}>(T{j} t) => new {className}<{genericArg}>({j}, value{j}: t);" :
                ""
        )}
        "));

        var matchArgList0 = Range(0, i).Joined(", ", e => $"Action<T{e}> f{e}");
        sb.AppendLine($@"
        public void Switch({matchArgList0})
        {{");

        for (var j = 0; j < i; j++) {
            sb.AppendLine($@"            if (_index == {j} && f{j} != null)
            {{
                f{j}(_value{j});
                return;
            }}");
        }

        sb.AppendLine(@"            throw new InvalidOperationException();
        }");

        var matchArgList = Range(0, i).Joined(", ", e => $"Func<T{e}, TResult> f{e}");
        sb.AppendLine($@"
        public TResult Match<TResult>({matchArgList})
        {{");

        for (var j = 0; j < i; j++) {
            sb.AppendLine($@"            if (_index == {j} && f{j} != null)
            {{
                return f{j}(_value{j});
            }}");
        }

        sb.AppendLine(@"            throw new InvalidOperationException();
        }");

        if (isStruct) {
            var argIndexList = Range(0, i).ToList();
            var genericArgs = argIndexList.Select(e => $"T{e}").ToList();
            var genericArgsPrinted = genericArgs.Joined(", ");

            sb.AppendLine(Range(0, i).Joined("", j => @$"
        public static OneOf<{genericArgsPrinted}> FromT{j}(T{j} input) => input;"));

            foreach (var bindToType in genericArgs) {

                var resultType = "TResult";
                var resultArgs = genericArgs.Select(x => {
                    return x == bindToType ? resultType : x;
                }).ToList();
                var resultArgsPrinted = resultArgs.Joined(", ");
                var funcType =
                sb.Append($@"
        public OneOf<{resultArgsPrinted}> Map{bindToType}<{resultType}>(Func<{bindToType}, {resultType}> mapFunc)
        {{");
                sb.Append($@"
            if(mapFunc == null)
            {{
                throw new ArgumentNullException(nameof(mapFunc));
            }}
            return _index switch
            {{
                {Range(0, i).Joined(@"
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
        if (i > 1)
            for (var j = 0; j < i; j++) {

                var genericArgWithSkip = Range(0, i).Except(new[] { j }).Joined(", ", e => $"T{e}");
                var remainderType = i == 2 ? genericArgWithSkip : $"OneOf<{genericArgWithSkip}>";
                sb.AppendLine($@"
		public bool TryPickT{j}(out T{j} value, out {remainderType} remainder)
		{{
            value = IsT{j} ? AsT{j} : default;
            remainder = _index switch
            {{
                {Range(0, i).Joined(@"
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

        sb.AppendLine($@"
        bool Equals({className}<{genericArg}> other) =>
            _index == other._index &&
            _index switch
            {{
                {Range(0, i).Joined("", j => @$"
                {j} => Equals(_value{j}, other._value{j}),")}
                _ => false
            }};");

        if (isStruct) {
            sb.AppendLine(@$"
        public override bool Equals(object obj) => obj is {className}<{genericArg}> o && Equals(o);");
        } else {
            sb.AppendLine($@"
        public override bool Equals(object obj)
        {{
            if (ReferenceEquals(null, obj))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            return obj is {className}<{genericArg}> o && Equals(o);
        }}");
        }

        sb.AppendLine($@"
        public override string ToString()
        {{{(isStruct ? "" : @"
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $""{type.FullName}: {value?.ToString()}"";")}
            return _index switch
            {{
                {Range(0, i).Joined(@"
                ", j => $"{j} => FormatValue(typeof(T{j}), _value{j}),")}
                _ => throw new InvalidOperationException(""Unexpected index, which indicates a problem in the OneOf codegen."")
            }};
        }}");

        sb.AppendLine($@"
        public override int GetHashCode()
        {{
            int hashCode = _index switch
            {{
                {Range(0, i).Joined(@"
                ", j => $"{j} => _value{j}?.GetHashCode() ?? 0,")}
                _ => 0
            }};
            return (hashCode*397) ^ _index;
        }}
    }}");
    }
    sb.AppendLine("}");
    return sb.ToString(); ;
}

public static class Extensions {
    public static string Joined<T>(this IEnumerable<T> source, string delimiter, Func<T, string>? selector = null) {
        if (source == null) { return ""; }
        if (selector == null) { return string.Join(delimiter, source); }
        return string.Join(delimiter, source.Select(selector));
    }
    public static void AppendTo(this string? s, StringBuilder sb) => sb.Append(s);
    public static void AppendLineTo(this string? s, StringBuilder sb) => sb.AppendLine(s);
}