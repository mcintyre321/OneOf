<Query Kind="Program" />

void Main()
{
    var output = GetContent(true).Dump();
    var outpath = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "OneOf.cs");
    File.WriteAllText(outpath.Dump(), output);

    var output2 = GetContent(false);
    var outpath2 = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "OneOfBase.cs");
    File.WriteAllText(outpath2.Dump(), output2);
}

public string GetContent(bool isStruct)
{
    var className = isStruct ? "OneOf" : "OneOfBase";
    var sb = new StringBuilder();
    sb.Append(@"using System;

namespace OneOf
{");
    for (var i = 1; i < 10; i++)
    {
        var genericArg = string.Join(", ", Enumerable.Range(0, i).Select(e => $"T{e}"));

        sb.AppendLine($@"
    public {(isStruct ? "struct" : "class")} {className}<{genericArg}> : IOneOf");
        if (!isStruct)
        {
            for (var j = 0; j < i; j++)
            {
                sb.AppendLine($"        where T{j} : class");
            }
        }
        sb.AppendLine("    {");
        for (var j = 0; j < i; j++)
        {
            sb.AppendLine($@"        readonly T{j} _value{j};");
        }

        sb.Append($@"        readonly int _index;
    
        {className}(int index");
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
                sb.AppendLine($@"            {{
                var value = this as T{j};
                if (value != null)
                {{
                    _index = {j};
                    _value{j} = value;
                    return;
                }}
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
            sb.AppendLine($@"            if (IsT{j} && f{j} != null)
            {{
                f{j}(AsT{j});
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
            sb.AppendLine($@"            if (IsT{j} && f{j} != null)
            {{
                return f{j}(AsT{j});
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
            sb.AppendLine($@"            if (IsT{j} && f{j} != null)
            {{
                return f{j}(AsT{j});
            }}");
        }

        sb.AppendLine(@"            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }");

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
    return sb.ToString(); ;
}