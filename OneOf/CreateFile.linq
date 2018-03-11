<Query Kind="Program" />

void Main()
{
    var output = GetContent(true).Dump();
    var outpath = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "OneOf.cs");
    File.WriteAllText(outpath.Dump(), output);

    var output2 = GetContent(false);
    var outpath2 = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "OneOfBase.cs");
    File.WriteAllText(outpath2.Dump(), output2);
    
    var output3 = GetInterfaceContent();
    var outpath3 = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "IOneOf.cs");
    File.WriteAllText(outpath3.Dump(), output3);
}

public string GetInterfaceContent(){
    var sb = new StringBuilder();
    sb.Append(@"using System;

namespace OneOf
{
    public interface IOneOf { object Value { get ; } }
");
    for (var i = 1; i < 33; i++)
    {
        var genericArg = string.Join(", ", Enumerable.Range(0, i).Select(e => $"T{e}"));

        sb.Append($@"
    public interface IOneOf<{genericArg}>
    {{");
        var matchArgList0 = string.Join(", ", Enumerable.Range(0, i).Select(e => $"Action<T{e}> f{e}"));
        sb.Append($@"
        void Switch({matchArgList0});");

        var matchArgList = string.Join(", ", Enumerable.Range(0, i).Select(e => $"Func<T{e}, TResult> f{e}"));
        sb.Append($@"
        TResult Match<TResult>({matchArgList});");

        sb.AppendLine(@"
    }");
    }
    sb.AppendLine("}");
    return sb.ToString();
}

public string GetContent(bool isStruct)
{
    var className = isStruct ? "OneOf" : "OneOfBase";
    var sb = new StringBuilder();
    sb.Append(@"using System;

namespace OneOf
{");
    for (var i = 1; i < 33; i++)
    {
        var genericArg = string.Join(", ", Enumerable.Range(0, i).Select(e => $"T{e}"));

        sb.AppendLine($@"
    public {(isStruct ? "struct" : "class")} {className}<{genericArg}> : IOneOf, IOneOf<{genericArg}>");
        sb.AppendLine("    {");
        for (var j = 0; j < i; j++)
        {
            sb.AppendLine($@"        readonly T{j} _value{j};");
        }

        sb.Append($@"        readonly int _index;

        {(isStruct ? "" : "protected ")}{className}(int index");
        for (var j = 0; j < i; j++)
        {
            sb.Append($", T{j} value{j} = default(T{j})");
        }
        sb.Append(@")
        {
            _index = index;");
        for (var j = 0; j < i; j++)
        {
            sb.Append($@"
            _value{j} = value{j};");
        }
        sb.AppendLine(@"
        }");

        if (!isStruct)
        {
            sb.AppendLine($@"
        protected {className}()
        {{");

            for (var j = 0; j < i; j++)
            {
                sb.AppendLine($@"            if (this is T{j})
            {{
                _index = {j};
                _value{j} = (T{j})(object)this;
                return;
            }}");
            }

            sb.AppendLine(@"        }");
        }

        sb.Append(@"
        object IOneOf.Value
        {
            get
            {
                switch (_index)
                {");
        for (var j = 0; j < i; j++)
        {
            sb.Append($@"
                    case {j}:
                        return _value{j};");
        }
        sb.AppendLine(@"
                    default:
                        throw new InvalidOperationException();
                }
            }
        }");
        for (var j = 0; j < i; j++)
        {
            sb.AppendLine(
        $@"
        public bool IsT{j}
        {{
            get {{ return _index == {j}; }}
        }}

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

        public static implicit operator {className}<{genericArg}>(T{j} t)
        {{
             return new {className}<{genericArg}>({j}, value{j}: t);
        }}");
        }

        var matchArgList0 = string.Join(", ", Enumerable.Range(0, i).Select(e => $"Action<T{e}> f{e}"));
        sb.AppendLine($@"
        public void Switch({matchArgList0})
        {{");

        for (var j = 0; j < i; j++)
        {
            sb.AppendLine($@"            if (_index == {j} && f{j} != null)
            {{
                f{j}(_value{j});
                return;
            }}");
        }

        sb.AppendLine(@"            throw new InvalidOperationException();
        }");

        var matchArgList = string.Join(", ", Enumerable.Range(0, i).Select(e => $"Func<T{e}, TResult> f{e}"));
        sb.AppendLine($@"
        public TResult Match<TResult>({matchArgList})
        {{");

        for (var j = 0; j < i; j++)
        {
            sb.AppendLine($@"            if (_index == {j} && f{j} != null)
            {{
                return f{j}(_value{j});
            }}");
        }

        sb.AppendLine(@"            throw new InvalidOperationException();
        }");

        var matchArgList2 = string.Join(", ", Enumerable.Range(0, i).Select(e => $"Func<T{e}, TResult> f{e} = null"));
        sb.AppendLine($@"
        public TResult MatchSome<TResult>({matchArgList2}, Func<TResult> otherwise = null)
        {{");

        for (var j = 0; j < i; j++)
        {
            sb.AppendLine($@"            if (_index == {j} && f{j} != null)
            {{
                return f{j}(_value{j});
            }}");
        }

        sb.AppendLine(@"            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }");

        if(isStruct){
            var argIndexList = Enumerable.Range(0, i).ToList();
            var genericArgs = argIndexList.Select(e => $"T{e}").ToList();
            var genericArgsPrinted = string.Join(", ", genericArgs);

            foreach(var bindToType in genericArgs){
                sb.AppendLine($@"
        public static OneOf<{genericArgsPrinted}> From{bindToType}({bindToType} input)
        {{
            return input;
        }}");
            }

            foreach(var bindToType in genericArgs){

                var resultType = "TResult";
                var resultArgs = genericArgs.Select(x => {
                    return x == bindToType ? resultType : x;
                }).ToList();
                var resultArgsPrinted = string.Join(", ", resultArgs);
                var funcType =
                sb.Append($@"
        public OneOf<{resultArgsPrinted}> Map{bindToType}<{resultType}>(Func<{bindToType}, {resultType}> mapFunc)
        {{");
                sb.Append($@"
            if(mapFunc == null)
            {{
                throw new ArgumentNullException(nameof(mapFunc));
            }}");

                sb.Append($@"
            return Match<OneOf<{resultArgsPrinted}>>(");
                var appendStrings = argIndexList.Select(x => {
                    return $"T{x}" == bindToType ?
                        $"input{x} => mapFunc(input{x})":
                        $"input{x} => input{x}";
                }).ToList();
                for (var appendedStringIndex = 0; appendedStringIndex < appendStrings.Count; appendedStringIndex++)
                {
                    if(appendedStringIndex != appendStrings.Count -1){
                        sb.Append($@"
                {appendStrings[appendedStringIndex]},");
                    }else{
                        sb.Append($@"
                {appendStrings[appendedStringIndex]}");
                    }
                }
                sb.Append($@"
            );");
                sb.AppendLine($@"
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
            {{");
        for (var j = 0; j < i; j++)
        {
            sb.AppendLine($@"                case {j}:
                    return Equals(_value{j}, other._value{j});");
        }
        sb.AppendLine(@"                default:
                    return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }");
        if (isStruct)
        {
            sb.AppendLine($@"
            return obj is {className}<{genericArg}> && Equals(({className}<{genericArg}>)obj);");
        }
        else
        {
            sb.AppendLine($@"
            if (ReferenceEquals(this, obj))
            {{
                return true;
            }}

            var other = obj as OneOfBase<{genericArg}>;
            return other != null && Equals(other);");
        }

        sb.AppendLine(@"        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {");
        for (var j = 0; j < i; j++)
        {
            sb.AppendLine($@"                    case {j}:
                    hashCode = _value{j}?.GetHashCode() ?? 0;
                    break;");
        }
        sb.AppendLine(@"                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }");
    }
    sb.AppendLine("}");
    return sb.ToString();
}