<Query Kind="Program" />

void Main()
{
	var sb = new StringBuilder();
	sb.AppendLine(@"
using System;
namespace OneOf
{
    public interface IOneOf { object Value { get ; } }
	");
	for (var i = 1; i < 10; i++)
	{
		var genericArg = string.Join(", ", Enumerable.Range(0, i).Select(e => "T" + e));



	
		sb.AppendLine(string.Format(

@"
	public struct OneOf<{0}> : IOneOf
    {{
	    readonly object value;
	    readonly int index;

	    OneOf(object value, int index)	    {{ this.value = value; this.index = index;	     }}
	
		object IOneOf.Value {{ get {{ return value; }} }}
	
	    T Get<T>(int index)
	    {{
		    if (index != this.index)
		    {{
		    	throw new InvalidOperationException(""Cannot return as T"" + index + "" as result is T"" + this.index);
            }}
	        return (T)value;
	    }}
", genericArg));
		for (var j = 0; j < i; j++)
		{
			sb.AppendLine(string.Format(
@"
        public bool IsT{0} {{ get {{ return index == {0}; }} }}
        public T{0} AsT{0} {{ get {{ return Get<T{0}>({0}); }} }} 
        public static implicit operator OneOf<{1}> (T{0} t)
        {{
	         return new OneOf<{1}>(t, {0});
        }}
", j, genericArg));
		}

		var matchArgList = string.Join(", ", Enumerable.Range(0, i).Select(e => "Func<T" + e + ", TResult> f" + e + " = null"));
		sb.AppendLine(string.Format(@"
	    public static Func<OneOf<{0}>, TResult > Match<TResult>({1}, Func<TResult> otherwise = null)
        {{
			return oneof =>
			{{", genericArg, matchArgList));

		for (var j = 0; j < i; j++)
		{
			sb.AppendLine(string.Format(@"					if (oneof.IsT{0} && f{0} != null) return f{0}(oneof.AsT{0});", j));
		}

		sb.AppendLine(string.Format(@"
		        if (otherwise != null) return otherwise();
	    		throw new InvalidOperationException();
    		}};
		}}
		
		bool Equals(OneOf<{0}> other)
        {{
            return index == other.index && Equals(value, other.value);
        }}

        public override bool Equals(object obj)
        {{
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is OneOf<{0}> && Equals(obj);
        }}

        public override int GetHashCode()
        {{
            unchecked
            {{
                return ((value != null ? value.GetHashCode() : 0)*397) ^ index;
            }}
        }}

	}}
", genericArg));
	}
	sb.AppendLine("}");
	sb.ToString().Dump();
	var outpath = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "OneOf.cs");
	File.WriteAllText(outpath.Dump(), sb.ToString());
}