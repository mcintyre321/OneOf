# Changelog

## 4.0.0-preview.1

### New
- **C# 15 union types.** `OneOf<...>` structs (including `OneOf.Extended`) and `[GenerateOneOf]` classes are C# unions: pattern matching applies to the contained value, and `switch` expressions over the case types are checked for exhaustiveness. This works on every supported target framework when compiled with a C# 15 compiler; older compilers are unaffected.
- `OneOf<...>` has a public constructor per case type (`new OneOf<Cat, Dog>(dog)`), plus `HasValue` and `TryGetValue(out T𝑥)` members (also on `OneOfBase`).
- `[GenerateOneOf]` classes get a public constructor per case type and an implicit conversion from the matching `OneOf<...>`.
- Packages include the README, SourceLink and deterministic builds.

### Breaking changes
- **Target frameworks** are now `netstandard2.0`, `net8.0` and `net10.0`. `net35`, `net45`/`net451` and `netstandard1.3` are no longer supported; .NET Framework 4.6.2+ is still supported through `netstandard2.0`.
- **`[GenerateOneOf]` classes:** the constructor taking a `OneOf<...>` is now `protected` (or `private` for sealed classes). A public one would make `OneOf<...>` a union case and break exhaustive switches. Replace `new MyType(oneOf)` with `(MyType)oneOf`, or `MyType x = oneOf;`.
- **Under C# 15 only**, patterns on a OneOf apply to the value inside it. For example, `oneOf is null` is now valid, and is true when the contained value is null; for `[GenerateOneOf]` classes it is also true when the instance itself is null.
