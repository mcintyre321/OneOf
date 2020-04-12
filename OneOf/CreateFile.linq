<Query Kind="Program" />

void Main()
{
	var output = GetContent(true, 1, 10).Dump();
	var outpath = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "OneOf.cs");
	File.WriteAllText(outpath.Dump(), output);

	var output2 = GetContent(false, 1, 10);
	var outpath2 = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "OneOfBase.cs");
	File.WriteAllText(outpath2.Dump(), output2);
	
	var output3 = GetContent(true, 10, 33).Dump();
	var outpath3 = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "..\\OneOf.Extended\\OneOf.cs");
	File.WriteAllText(outpath3.Dump(), output3);

	var output4 = GetContent(false, 10, 33);
	var outpath4 = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "..\\OneOf.Extended\\OneOfBase.cs");
	File.WriteAllText(outpath4.Dump(), output4);

}

public static IEnumerable<T[]> GetPermutations<T>(T[] values)
{
	if (values.Length == 1)
		return new[] { values };

	return values.SelectMany(v => GetPermutations(values.Except(new[] { v }).ToArray()),
		(v, p) => new[] { v }.Concat(p).ToArray());
}

public string GetContent(bool isStruct, int indexStart, int indexEnd)
{
	var className = isStruct ? "OneOf" : "OneOfBase";
	var sb = new StringBuilder();
	sb.Append(@"using System;

namespace OneOf
{");
	for (var i = indexStart; i < indexEnd; i++)
	{
		var genericArg = string.Join(", ", Enumerable.Range(0, i).Select(e => $"T{e}"));

		sb.AppendLine($@"
    public {(isStruct ? "struct" : "class")} {className}<{genericArg}> : IOneOf");
		sb.AppendLine("    {");
		
		RenderOneOf(sb, className, genericArg, isStruct, i);
	}
	sb.AppendLine("}");
	return sb.ToString(); ;
}

public void RenderOneOf(StringBuilder sb, string className, string genericArg, bool isStruct, int i)
{
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
        public object Value
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
        public bool IsT{j} => _index == {j};

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

        public static implicit operator {className}<{genericArg}>(T{j} t) => new {className}<{genericArg}>({j}, value{j}: t);
");
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

	if (isStruct)
	{
		var argIndexList = Enumerable.Range(0, i).ToList();
		var genericArgs = argIndexList.Select(e => $"T{e}").ToList();
		var genericArgsPrinted = string.Join(", ", genericArgs);

		foreach (var bindToType in genericArgs)
		{
			sb.AppendLine($@"
        public static OneOf<{genericArgsPrinted}> From{bindToType}({bindToType} input)
        {{
            return input;
        }}");
		}

		foreach (var bindToType in genericArgs)
		{

			var resultType = "TResult";
			var resultArgs = genericArgs.Select(x =>
			{
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
			var appendStrings = argIndexList.Select(x =>
			{
				return $"T{x}" == bindToType ?
					$"input{x} => mapFunc(input{x})" :
					$"input{x} => input{x}";
			}).ToList();
			for (var appendedStringIndex = 0; appendedStringIndex < appendStrings.Count; appendedStringIndex++)
			{
				if (appendedStringIndex != appendStrings.Count - 1)
				{
					sb.Append($@"
                {appendStrings[appendedStringIndex]},");
				}
				else
				{
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
	if (i > 1)
		for (var j = 0; j < i; j++)
		{

			var genericArgWithSkip = string.Join(", ", Enumerable.Range(0, i).Except(new[] { j }).Select(e => $"T{e}"));
			var remainderType = i == 2 ? genericArgWithSkip : $"OneOf<{genericArgWithSkip}>";
			sb.AppendLine($@"
		public bool TryPickT{j}(out T{j} value, out {remainderType} remainder)
		{{
			value = this.IsT{j} ? this.AsT{j} : default(T{j});
			remainder = " + ((i == 2) ? ($"this.IsT{j} ? default({remainderType}) : this.As{remainderType};") : $@"this.IsT{j}
				? default(OneOf<{genericArgWithSkip}>) 
				: this.Match<{remainderType}>(" + String.Join(", ", Enumerable.Range(0, i).Select(k => $"t{k} =>" + (k == j ? "throw new InvalidOperationException()" : $"t{k}"))) + $@");")
			+ $@"
			return this.IsT{j};
		}}");
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
		sb.AppendLine($@"                case {j}: return Equals(_value{j}, other._value{j});");
	}
	sb.AppendLine(@"                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            ");
	if (isStruct)
	{
		sb.AppendLine($@"
            return obj is {className}<{genericArg}> && Equals(({className}<{genericArg}>)obj);");
	}
	else
	{
		sb.AppendLine($@"
            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<{genericArg}>;
            return other != null && Equals(other);");
	}

	sb.AppendLine(@"        }");
	sb.AppendLine(@"
        public override string ToString()
        {");
	if (isStruct)
	{
		sb.AppendLine(@"            string FormatValue<T>(Type type, T value) => $""{type.FullName}: {value?.ToString()}"";");
	}
	else
	{
		sb.AppendLine(@"            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $""{type.FullName}: {value?.ToString()}"";");
	}
	sb.AppendLine(@"            switch(_index) {");
	for (var j = 0; j < i; j++)
	{
		sb.AppendLine($"                case {j}: return FormatValue(typeof(T{j}), _value{j});");
	}
	sb.Append(@"                default: throw new InvalidOperationException(""Unexpected index, which indicates a problem in the OneOf codegen."");
            }
        }");
	sb.AppendLine(@"

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
        }");
	
	if( i <= 5 )
	{
		sb.AppendLine();
		sb.AppendLine("#region Rearrange (not subset)");
		sb.AppendLine();

		String[] typeParameters = Enumerable.Range(0, i).Select(e => $"T{e}").ToArray();
		var permutations = GetPermutations(typeParameters);
		foreach (String[] typeParameterPermutation in permutations)
		{
			String permutation = String.Join(", ", typeParameterPermutation);

			String matchFuncs = String.Join(", ", Enumerable.Range(0, i).Select(n => $"v{n} => v{n}"));

			sb.AppendLine($@"        public static {className}<{genericArg}> RearrangeFrom( {className}<{permutation}> other ) => other.Match< {className}<{genericArg}> >( {matchFuncs} );");
			sb.AppendLine();
		}

		sb.AppendLine();
		sb.AppendLine("#endregion");

		sb.AppendLine();
	}

	sb.AppendLine(@"    }");
}