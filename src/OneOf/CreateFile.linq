<Query Kind="Program" />

void Main()
{
    var output = GetContent(true)
        .Dump();
    var outpath = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "OneOf.cs");
    File.WriteAllText(outpath.Dump(), output);

    var output2 = GetContent(false);
    var outpath2 = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "OneOfBase.cs");
    File.WriteAllText(outpath2.Dump(), output2);
}

private static string GetContent(bool isStruct)
{
    var sb = new StringBuilder();
    sb.AppendLine(@"
using System;

namespace OneOf.Structs
{");
    for (var i = 1; i < 10; i++)
    {
        var genericArg = string.Join(", ", Enumerable.Range(0, i)
                                                        .Select(e => $"T{e}"));
        sb.AppendLine($@"    public struct OneOfStruct<{genericArg}> : IOneOf
    {{
        private readonly object _value;
        private readonly int _index;

        private OneOfStruct(object value, int index)
        {{
            this._value = value;
            this._index = index;
        }}

        object IOneOf.Value
            => _value;

        private T Get<T>(int index)
        {{
            if (index != this._index)
            {{
                throw new InvalidOperationException($""Cannot return as T{{index}} as result is T{{this._index}}"");
            }}
            return (T)_value;
        }}");

        for (var j = 0; j < i; j++)
        {
            sb.AppendLine($@"
        public bool IsT{j}
            => _index == {j};

        public T{j} AsT{j}
            => Get<T{j}>({j});

        public static implicit operator OneOfStruct<{genericArg}> (T{j} t)
            => new OneOfStruct<{genericArg}>(t, {j});");
        }

        var matchArgList0 = string.Join(", ", Enumerable.Range(0, i)
                                                        .Select(e => $"Action<T{e}> f{e}"));

        sb.AppendLine($@"
        public void Switch({matchArgList0})
        {{");

        for (var j = 0; j < i; j++)
        {
            sb.AppendLine($@"            if (this.IsT{j} && f{j} != null)
            {{
                f{j}(this.AsT{j});
                return;
            }}");
        }

        sb.AppendLine(@"
            throw new InvalidOperationException();
        }");

        var matchArgList = string.Join(", ", Enumerable.Range(0, i)
                                                       .Select(e => $"Func<T{e}, TResult> f{e}"));
        sb.AppendLine($@"
        public TResult Match<TResult>({matchArgList})
        {{");

        for (var j = 0; j < i; j++)
        {
            sb.AppendLine($@"            if (this.IsT{j} && f{j} != null)
            {{
                return f{j}(this.AsT{j});
            }}");
        }

        sb.AppendLine(@"
            throw new InvalidOperationException();
        }");

        var matchArgList2 = string.Join(", ", Enumerable.Range(0, i)
                                                        .Select(e => $"Func<T{e}, TResult> f{e} = null"));
        sb.AppendLine($@"
        public TResult MatchSome<TResult>({matchArgList2}, Func<TResult> otherwise = null)
        {{");

        for (var j = 0; j < i; j++)
        {
            sb.AppendLine($@"            if (this.IsT{j} && f{j} != null)
            {{
                return f{j}(this.AsT{j});
            }}");
        }

        sb.AppendLine(@"
            if (otherwise != null) { return otherwise(); }

            throw new InvalidOperationException();
        }");

        if (!isStruct)
        {
            sb.AppendLine(@"
        protected OneOfBase()
        {
            this._value = this;");

            for (var j = 0; j < i; j++)
            {
                sb.AppendLine($@"
            if (this is T{j})
            {{
                this._index = {j};
            }}");
            }

            sb.AppendLine(@"        }");

        }
        sb.AppendLine($@"
        private bool Equals(OneOfStruct<{genericArg}> other)
            => _index == other._index && Equals(_value, other._value);

        public override bool Equals(object obj)
        {{
            if (ReferenceEquals(null, obj))
            {{
                return false;
            }}
");
        if(isStruct)
        {
            sb.AppendLine($@"            return obj is OneOfStruct<{genericArg}> && Equals((OneOfStruct<{genericArg}>) obj);");
        }
        else
        {
            sb.AppendLine($@"            if (ReferenceEquals(this, obj))
            {{
                return true;
            }}

            var other = obj as OneOfBase<{genericArg}>;
            return other != null && Equals(other);");
        }
            
        sb.AppendLine($@"        }}

        public override int GetHashCode()
        {{
            unchecked
            {{
                return ((_value?.GetHashCode() ?? 0)*397) ^ _index;
            }}
        }}
    }}
");
    }
    sb.AppendLine("}");
    var content = sb.ToString();
    if (isStruct)
    {
        return content.Replace(".Structs", "")
                      .Replace("OneOfStruct", "OneOf");
    }
    return content.Replace("struct", "class")
                  .Replace(".Structs", "")
                  .Replace("OneOfStruct", "OneOfBase");
}