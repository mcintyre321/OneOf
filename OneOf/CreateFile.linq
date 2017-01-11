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
    var sb = new StringBuilder();
    sb.AppendLine(@"
using System;

namespace OneOf.Structs
{");
    for (var i = 1; i < 10; i++)
    {
        var genericArg = string.Join(", ", Enumerable.Range(0, i).Select(e => $"T{e}"));
    
        sb.AppendLine($@"    public struct OneOfStruct<{genericArg}> : IOneOf
    {{
        readonly object value;
        readonly int index;
        
        OneOfStruct(object value, int index)
        {{
            this.value = value; 
            this.index = index;
        }}
    
        object IOneOf.Value 
        {{
            get {{ return value; }}
        }}
    
        T Get<T>(int index)
        {{
            if (index != this.index)
            {{
                throw new InvalidOperationException($""Cannot return as T{{index}} as result is T{{this.index}}"");
            }}
            return (T)value;
        }}");
        for (var j = 0; j < i; j++)
        {
            sb.AppendLine(
$@"
        public bool IsT{j}
        {{
            get {{ return index == {j}; }}
        }}
        
        public T{j} AsT{j}
        {{
            get {{ return Get<T{j}>({j}); }}
        }}
        
        public static implicit operator OneOfStruct<{genericArg}> (T{j} t)
        {{
             return new OneOfStruct<{genericArg}>(t, {j});
        }}
");
        }

        var matchArgList0 = string.Join(", ", Enumerable.Range(0, i).Select(e => $"Action<T{e}> f{e}"));
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

        sb.AppendLine(@"            throw new InvalidOperationException();
        }
");

        var matchArgList = string.Join(", ", Enumerable.Range(0, i).Select(e => $"Func<T{e}, TResult> f{e}"));
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

        sb.AppendLine(@"            throw new InvalidOperationException();
        }
");

        var matchArgList2 = string.Join(", ", Enumerable.Range(0, i).Select(e => $"Func<T{e}, TResult> f{e} = null"));
        sb.AppendLine($@"        public TResult MatchSome<TResult>({matchArgList2}, Func<TResult> otherwise = null)
        {{");

        for (var j = 0; j < i; j++)
        {
            sb.AppendLine($@"            if (this.IsT{j} && f{j} != null)
            {{
                return f{j}(this.AsT{j});
            }}");
        }

        sb.AppendLine(@"            if (otherwise != null)
            {
                return otherwise();
            }
            throw new InvalidOperationException();
        }");

        if (!isStruct)
        {
            sb.AppendLine(@"
        protected OneOfBase()
        {
            this.value = this;");

            for (var j = 0; j < i; j++)
            {
                
                sb.AppendLine($@"
            if (this is T{j})
            {{
                this.index = {j};
            }}");
            }

            sb.AppendLine(@"        }");

        }
        sb.AppendLine($@"
        bool Equals(OneOfStruct<{genericArg}> other)
        {{
            return index == other.index && Equals(value, other.value);
        }}

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
                return ((value?.GetHashCode() ?? 0)*397) ^ index;
            }}
        }}
    }}
");
    }
    sb.AppendLine("}");
    var content = sb.ToString();
    if (isStruct) return content.Replace(".Structs", "").Replace("OneOfStruct", "OneOf");
    return content.Replace("struct", "class").Replace(".Structs", "").Replace("OneOfStruct", "OneOfBase");
}