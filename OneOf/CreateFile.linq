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
using Newtonsoft.Json;

namespace OneOf.Structs
{
	");
	for (var i = 1; i < 10; i++)
	{
		var genericArg = string.Join(", ", Enumerable.Range(0, i).Select(e => "T" + e));



	
		sb.AppendLine(string.Format(

@"
    [JsonConverter(typeof(OneOfStructJsonConverter))]
	public struct OneOfStruct<{0}> : IOneOf
    {{
	    readonly object value;
	    readonly int index;
	    
		OneOfStruct(object value, int index)	    {{ this.value = value; this.index = index;	     }}
	
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
        public static implicit operator OneOfStruct<{1}> (T{0} t)
        {{
	         return new OneOfStruct<{1}>(t, {0});
        }}
", j, genericArg));
		}

		var matchArgList0 = string.Join(", ", Enumerable.Range(0, i).Select(e => "Action<T" + e + "> f" + e));
		sb.AppendLine(string.Format(@"
	    public void Switch({1})
        {{
			", genericArg, matchArgList0));

		for (var j = 0; j < i; j++)
		{
			sb.AppendLine(string.Format(@"			if (this.IsT{0} && f{0} != null) {{ f{0}(this.AsT{0}); return; }}", j));
		}

		sb.AppendLine(string.Format(@"
	    	throw new InvalidOperationException();
		}}
"));

		var matchArgList = string.Join(", ", Enumerable.Range(0, i).Select(e => "Func<T" + e + ", TResult> f" + e));
		sb.AppendLine(string.Format(@"
	    public TResult Match<TResult>({1})
        {{
			", genericArg, matchArgList));

		for (var j = 0; j < i; j++)
		{
			sb.AppendLine(string.Format(@"			if (this.IsT{0} && f{0} != null) return f{0}(this.AsT{0});", j));
		}

		sb.AppendLine(string.Format(@"
	    	throw new InvalidOperationException();
		}}
"));

		var matchArgList2 = string.Join(", ", Enumerable.Range(0, i).Select(e => "Func<T" + e + ", TResult> f" + e + " = null"));
		sb.AppendLine(string.Format(@"
	    public TResult MatchSome<TResult>({1}, Func<TResult> otherwise = null)
        {{
			", genericArg, matchArgList2));

		for (var j = 0; j < i; j++)
		{
			sb.AppendLine(string.Format(@"
			if (this.IsT{0} && f{0} != null) return f{0}(this.AsT{0});", j));
		}

		sb.AppendLine(string.Format(@"
		    if (otherwise != null) return otherwise();
	    	throw new InvalidOperationException();
		}}
"));

		if (!isStruct)
		{
			sb.AppendLine(@"
		
		protected OneOfBase()
		{
			this.value = this;");

			for (var j = 0; j < i; j++)
			{
				
				sb.AppendLine(string.Format(@"
			if (this is T{0}) this.index = {0};", j));
			}

			sb.AppendLine(@"
		}");

		}
		sb.AppendLine(string.Format(@"
		
		bool Equals(OneOfStruct<{0}> other)
        {{
            return index == other.index && Equals(value, other.value);
        }}

        public override bool Equals(object obj)
        {{
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is OneOfStruct<{0}> && Equals(obj);
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
	var content = sb.ToString();
	if (isStruct) return content.Replace(".Structs", "").Replace("OneOfStruct", "OneOf");
	return content.Replace("struct", "class").Replace(".Structs", "").Replace("OneOfStruct", "OneOfBase");
}