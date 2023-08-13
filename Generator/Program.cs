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
    string OrdinalOf(int cardinal) => (cardinal + 1) switch
    {
        //0 => "zeroth",
        //^ consider zero-based ordinals for consistency with T0?
        //If so, adapt exception in default case and last case,
        //as well as switch argument
        1 => "first",
        2 => "second",
        3 => "third",
        4 => "fourth",
        5 => "fifth",
        6 => "sixth",
        7 => "seventh",
        8 => "eigth",
        9 => "ninth",
        10 => "tenth",
        11 => "eleventh",
        12 => "twelfth",
        21 => "21st",
        22 => "22nd",
        31 => "31st",
        32 => "32nd",
        < 31 => $"{cardinal}th",
        _ => throw new ArgumentOutOfRangeException(nameof(cardinal), cardinal, $"{nameof(cardinal)} must be between 1 and 32 (inclusive).")
    };

    const string THROW_INDEX_EX = "throw new InvalidOperationException(\"Unexpected index, which indicates a problem in the OneOf codegen.\")";

    var className = isStruct ? "OneOf" : "OneOfBase";
    var genericArgs = Range(0, i).Select(e => $"T{e}").ToList();
    var genericArg = genericArgs.Joined(", ");
    var sb = new StringBuilder();
    sb.Append(@$"using System;
using static OneOf.Functions;

namespace OneOf
{{
    /// <summary>
    /// Represents a discriminated union of {i} type{(i > 1 ? "s" : "")}.
    /// </summary>
{RangeJoined(@"
", j => $"    /// <typeparam name=\"T{j}\">The {OrdinalOf(j)} type of value this type of union is able to represent.</typeparam>")}
    public {IfStruct("readonly struct", "class")} {className}<{genericArg}> : IOneOf{IfStruct($", IEquatable<{className}<{genericArg}>>")}
    {{
        {RangeJoined(@"
        ", j => $"readonly T{j} _value{j};")}
        readonly int _index;

        {IfStruct( // constructor
        $@"OneOf(int index, {RangeJoined(", ", j => $"T{j} value{j} = default")})
        {{
            _index = index;
            {RangeJoined(@"
            ", j => $"_value{j} = value{j};")}
        }}",
        $@"/// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name=""input"">The union based on which to set the type and value represented by this union.</param>
        protected OneOfBase(OneOf<{genericArg}> input)
        {{
            _index = input.Index;
            switch (_index)
            {{
                {RangeJoined($@"
                ", j => $@"case {j}: 
                    _value{j} = input.AsT{j}; 
                    break;")}
                default: 
                    {THROW_INDEX_EX};
            }}
        }}"
        )}
        
        /// <summary>
        /// Gets the type of value represented by this union.
        /// </summary>
        public Type GetRepresentedType()=>
            _index switch
            {{
                {RangeJoined(@"
                ", j => $"{j} => typeof(T{j}),")}
                _ => {THROW_INDEX_EX}
            }};

        /// <summary>
        /// Gets the value represented by this union.
        /// </summary>
        public object Value =>
            _index switch
            {{
                {RangeJoined(@"
                ", j => $"{j} => _value{j},")}
                _ => {THROW_INDEX_EX}
            }};

        /// <summary>
        /// Gets the index indicating the type of value represented by this union.
        /// </summary>
        public int Index => _index;

        {RangeJoined(@"
        ",
j => $@"/// <summary>
        /// Gets a value indicating whether this union is representing a value of type <typeparamref name=""T{j}""/>.
        /// </summary>
        public bool IsT{j} => _index == {j};")}

        {RangeJoined(@"
        ",
j => $@"/// <summary>
        /// Gets the value represented by this union if it is representing a value of type <typeparamref name=""T{j}""/>.
        /// Otherwise, an <see cref=""InvalidOperationException""/> will be thrown.
        /// </summary>
        public T{j} AsT{j} =>
            _index == {j} ?
                _value{j} :
                throw new InvalidOperationException($""Cannot return the value represented as T{j} ({{typeof(T{j}).FullName}}) because the type of value represented is T{{_index}} ({{GetRepresentedType().FullName}})"");")}

        {IfStruct(RangeJoined(@"
        ", j => $"public static implicit operator {className}<{genericArg}>(T{j} value) => new {className}<{genericArg}>({j}, value{j}: value);"))}

        /// <summary>
        /// Executes a delegate based on the type of value represented by this union.
        /// </summary>
{RangeJoined(@"
", j =>
$"\t\t/// <param name=\"f{j}\">The delegate to execute if this union represents a value of type <typeparamref name=\"T{j}\"/>.</param>")}
        public void Switch({RangeJoined(", ", j => $"Action<T{j}> f{j}")})
        {{
            switch(_index)
            {{
                {RangeJoined(@"
                ",
        j => $@"case {j}: 
                    if(f{j} == null)
                    {{
                        throw new ArgumentNullException(nameof(f{j}), $""The union is representing a value of type {{typeof(T{j}).FullName}} but no switch delegate was provided for its index."");
                    }}
                    f{j}.Invoke(_value{j});
                    return;")}
                default:
                    {THROW_INDEX_EX};
            }}
        }}

        /// <summary>
        /// Projects the value represented by this union onto the type <typeparamref name=""TResult""/>.
        /// </summary>
{RangeJoined(@"
", j =>
$"\t\t/// <param name=\"f{j}\">The projection to execute if this union represents a value of type <typeparamref name=\"T{j}\"/>.</param>")}
        /// <returns></returns>
        public TResult Match<TResult>({RangeJoined(", ", j => $"Func<T{j}, TResult> f{j}")})
        {{
            switch(_index)
            {{
                {RangeJoined(@"
                ",
        j => $@"case {j}: 
                    if(f{j} == null)
                    {{
                        throw new ArgumentNullException(nameof(f{j}), $""The union is representing a value of type {{typeof(T{j}).FullName}} but no match projection was provided for its index."");
                    }}
                    return f{j}.Invoke(_value{j});")}
                default:
                    {THROW_INDEX_EX};
            }}
        }}

        {IfStruct(genericArgs.Joined(@"
        ",
t => $@"/// <summary>
        /// Creates an instance of this union representing the value provided.
        /// </summary>
        /// <param name=""value"">The value to wrap inside a discriminated union instance.</param>
        public static OneOf<{genericArgs.Joined(", ")}> From{t}({t} value) => value;"))}

        {IfStruct(genericArgs.Joined(@"
            ", bindToType =>
{
    var resultArgsPrinted = genericArgs
        .Select(x => x == bindToType ? "TResult" : x)
        .Joined(", ");

    return $@"
        /// <summary>
        /// Maps this instance onto another union type of the same arity, 
        /// with its <typeparamref name=""{bindToType}""/> mapped to <typeparamref name=""TResult""/>.
        /// </summary>
        /// <param name=""mapFunc"">
        /// The delegate used to map this unions value onto <typeparamref name=""TResult""/>,
        /// if this union is representing it.
        /// </param>
        /// <typeparam name=""TResult"">The type to map <typeparamref name=""{bindToType}""/> onto.</typeparam>
        public OneOf<{resultArgsPrinted}> Map{bindToType}<TResult>(Func<{bindToType}, TResult> mapFunc)
        {{
            if (mapFunc == null)
            {{
                throw new ArgumentNullException(nameof(mapFunc));
            }}

            return _index switch
            {{
                {genericArgs.Joined(@"
                ", (x, k) =>
            x == bindToType ?
                $"{k} => mapFunc.Invoke(As{x})," :
                $"{k} => As{x},")}
                _ => {THROW_INDEX_EX}
            }};
        }}";
}))}
");

    if(i > 1)
    {
        sb.AppendLine(
            RangeJoined(@"
        ", j =>
            {
                var genericArgWithSkip = Range(0, i).ExceptSingle(j).Joined(", ", e => $"T{e}");
                var remainderType = i == 2 ? genericArgWithSkip : $"OneOf<{genericArgWithSkip}>";
                return $@"
        /// <summary>
        /// Attempts to retrieve the value represented by this union.
        /// </summary>
        /// <param name=""value"">
        /// Upon returning from the call, will contain the value represented 
        /// by this union if it represents a value of type 
        /// <typeparamref name=""T{j}""/>; otherwise, <see langword=""default""/>.
        /// </param>
        /// <param name=""remainder"">
        /// Upon returning from the call, will contain the union left after
        /// removing the requested type <typeparamref name=""T{j}""/> from this union 
        /// if it does <strong>not</strong> represent a value of type <typeparamref name=""T{j}""/>; otherwise, 
        /// <see langword=""default""/>.
        /// </param>
        /// <returns>
        /// <see langword=""true""/> if this union represents a value of type <typeparamref name=""T{j}""/>;
        /// otherwise, <see langword=""false""/>.
        /// </returns>
		public bool TryPickT{j}(out T{j} value, out {remainderType} remainder)
		{{
			value = IsT{j} ? AsT{j} : default;
            remainder = _index switch
            {{
                {RangeJoined(@"
                ", k =>
                    k == j ?
                        $"{k} => default," :
                        $"{k} => AsT{k},")}
                _ => {THROW_INDEX_EX}
            }};
			return this.IsT{j};
		}}";
            })
        );
    }

    sb.AppendLine(
$@"
        {IfStruct(@"/// <inheritdoc/>
        public ")}bool Equals({className}<{genericArg}> other) =>
            _index == other._index &&
            _index switch
            {{
                {RangeJoined(@"
                ", j => @$"{j} => Equals(_value{j}, other._value{j}),")}
                _ => false
            }};

        /// <inheritdoc/>
        public override bool Equals(object obj)=>
            {IfStruct(
            $"obj is OneOf<{genericArg}> o && Equals(o);",
            $"obj != null && (ReferenceEquals(this, obj) || obj is OneOfBase<{genericArg}> o && Equals(o));"
            )}

        /// <inheritdoc/>
        public override string ToString() =>
            _index switch {{
                {RangeJoined(@"
                ", j => $"{j} => FormatValue(_value{j}),")}
                _ => {THROW_INDEX_EX}
            }};

        /// <inheritdoc/>
        public override int GetHashCode()
        {{
            unchecked
            {{
                int hashCode = _index switch
                {{
                    {RangeJoined(@"
                    ", j => $"{j} => _value{j}?.GetHashCode(),")}
                    _ => 0
                }} ?? 0;
                return (hashCode*397) ^ _index;
            }}
        }}{IfStruct(@$"
        public static bool operator ==(OneOf<{genericArg}> a,OneOf<{genericArg}> b) =>
            a.Equals(b);
        public static bool operator !=(OneOf<{genericArg}> a,OneOf<{genericArg}> b) =>
            !(a == b);")}
    }}
}}");

    return sb.ToString();
}

public static class Extensions
{
    public static string Joined<T>(this IEnumerable<T> source, string delimiter, Func<T, string>? selector = null)
    {
        if(source == null)
        { return ""; }
        if(selector == null)
        { return string.Join(delimiter, source); }
        return string.Join(delimiter, source.Select(selector));
    }
    public static string Joined<T>(this IEnumerable<T> source, string delimiter, Func<T, int, string> selector)
    {
        if(source == null)
        { return ""; }
        return string.Join(delimiter, source.Select(selector));
    }
    public static IEnumerable<T> ExceptSingle<T>(this IEnumerable<T> source, T single) => source.Except(Repeat(single, 1));
    public static void AppendLineTo(this string? s, StringBuilder sb) => sb.AppendLine(s);
}