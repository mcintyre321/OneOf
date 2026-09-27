// Internal copies of attributes that the compiler recognises by name, for target frameworks
// that don't ship them. Being internal, they never clash with the real types in a consumer.

#if !NET11_0_OR_GREATER
namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Marks a type as a C# union type (C# 15+). The compiler then treats the type's
    /// single-parameter public constructors as its case types, giving union conversions,
    /// pattern matching on the contained value and exhaustive switch expressions.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
    internal sealed class UnionAttribute : Attribute
    {
    }
}
#endif

#if !NETCOREAPP3_0_OR_GREATER
namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    internal sealed class MaybeNullWhenAttribute : Attribute
    {
        public MaybeNullWhenAttribute(bool returnValue) => ReturnValue = returnValue;

        public bool ReturnValue { get; }
    }
}
#endif
