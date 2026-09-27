using System.Collections.Generic;
using Xunit;

namespace OneOf.UnionTests
{
    public record Cat(string Name);
    public record Dog(string Name);
    public record Bird(string Name);

    public class OneOfUnionTests
    {
        static string Describe(OneOf<Cat, Dog> pet) => pet switch
        {
            Cat c => "cat " + c.Name,
            Dog d => "dog " + d.Name,
            // No discard arm: the switch must be exhaustive over the case types.
        };

        [Fact]
        public void Switch_expression_over_case_types_is_exhaustive()
        {
            Assert.Equal("cat Tom", Describe(new Cat("Tom")));
            Assert.Equal("dog Rex", Describe(new Dog("Rex")));
        }

        [Fact]
        public void Case_constructors_create_the_union()
        {
            var pet = new OneOf<Cat, Dog>(new Dog("Rex"));

            Assert.True(pet.IsT1);
            Assert.Equal(new Dog("Rex"), pet.Value);
        }

        [Fact]
        public void Case_values_convert_implicitly()
        {
            OneOf<int, string> value = 42;

            Assert.True(value is int);
            Assert.False(value is string);
        }

        [Fact]
        public void Declaration_patterns_unwrap_value_types()
        {
            OneOf<int, bool, string> value = true;

            Assert.True(value is bool b && b);
            Assert.False(value is int);
        }

        [Fact]
        public void Constant_and_relational_patterns_apply_to_the_contained_value()
        {
            OneOf<int, string> value = 42;

            Assert.True(value is 42);
            Assert.True(value is > 40 and < 50);
            Assert.False(value is "42");
        }

        [Fact]
        public void Property_patterns_apply_to_the_contained_value()
        {
            OneOf<Cat, Dog> pet = new Cat("Tom");

            Assert.True(pet is Cat { Name: "Tom" });
            Assert.False(pet is Dog { Name: "Tom" });
        }

        [Fact]
        public void Null_pattern_matches_a_null_contained_value()
        {
            OneOf<string?, int> value = (string?)null;

            Assert.True(value is null);
            Assert.False(value.HasValue);

            var description = value switch
            {
                string s => s,
                int i => i.ToString(),
                null => "null",
            };
            Assert.Equal("null", description);
        }

        [Fact]
        public void Default_value_holds_the_default_of_the_first_case()
        {
            OneOf<int, string> value = default;

            Assert.True(value is 0);
            Assert.True(value.HasValue);
        }

        [Fact]
        public void TryGetValue_only_succeeds_for_the_current_case()
        {
            OneOf<int, string> value = "hello";

            Assert.False(value.TryGetValue(out int _));
            Assert.True(value.TryGetValue(out string? s));
            Assert.Equal("hello", s);
        }

        [Fact]
        public void Nested_unions_match_their_own_case_types()
        {
            OneOf<OneOf<int, string>, bool> value = (OneOf<int, string>)"inner";

            var description = value switch
            {
                OneOf<int, string> inner => inner switch
                {
                    int i => "int " + i,
                    string s => "string " + s,
                },
                bool b => "bool " + b,
            };
            Assert.Equal("string inner", description);
        }

        [Fact]
        public void Switch_statements_work_with_case_patterns()
        {
            var seen = new List<string>();
            foreach (OneOf<Cat, Dog, Bird> pet in new OneOf<Cat, Dog, Bird>[] { new Cat("Tom"), new Bird("Tweety") })
            {
                switch (pet)
                {
                    case Cat c: seen.Add(c.Name); break;
                    case Dog d: seen.Add(d.Name); break;
                    case Bird b: seen.Add(b.Name); break;
                }
            }
            Assert.Equal(new[] { "Tom", "Tweety" }, seen);
        }

        [Fact]
        public void Extended_arities_are_unions_too()
        {
            OneOf<int, long, short, byte, sbyte, uint, ulong, ushort, float, double, decimal> value = 1.5m;

            var description = value switch
            {
                int => "int",
                long => "long",
                short => "short",
                byte => "byte",
                sbyte => "sbyte",
                uint => "uint",
                ulong => "ulong",
                ushort => "ushort",
                float => "float",
                double => "double",
                decimal m => "decimal " + m,
            };
            Assert.Equal("decimal 1.5", description);
        }

        [Fact]
        public void Match_and_Switch_still_work_alongside_patterns()
        {
            OneOf<Cat, Dog> pet = new Dog("Rex");

            Assert.Equal("Rex", pet.Match(c => c.Name, d => d.Name));
        }
    }
}
