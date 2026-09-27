using Xunit;

namespace OneOf.UnionTests
{
    [GenerateOneOf]
    public partial class Pet : OneOfBase<Cat, Dog> { }

    [GenerateOneOf]
    public sealed partial class Answer : OneOfBase<int, string> { }

    [GenerateOneOf]
    public partial class Result<T> : OneOfBase<T, string> { }

    public class GeneratedUnionTests
    {
        static string Describe(Pet pet) => pet switch
        {
            Cat c => "cat " + c.Name,
            Dog d => "dog " + d.Name,
        };

        [Fact]
        public void Switch_expression_over_generated_class_is_exhaustive()
        {
            Assert.Equal("cat Tom", Describe(new Cat("Tom")));
            Assert.Equal("dog Rex", Describe(new Dog("Rex")));
        }

        [Fact]
        public void Case_constructors_create_the_union()
        {
            var pet = new Pet(new Dog("Rex"));

            Assert.True(pet.IsT1);
            Assert.True(pet is Dog { Name: "Rex" });
        }

        [Fact]
        public void A_OneOf_converts_implicitly_to_the_generated_class()
        {
            OneOf<Cat, Dog> oneOf = new Cat("Tom");
            Pet pet = oneOf;

            Assert.True(pet is Cat);
        }

        [Fact]
        public void Sealed_generated_class_is_a_union()
        {
            Answer answer = 42;

            var description = answer switch
            {
                int i => "int " + i,
                string s => "string " + s,
            };
            Assert.Equal("int 42", description);
        }

        [Fact]
        public void Generic_generated_class_is_a_union()
        {
            Result<int> result = 5;

            var description = result switch
            {
                int i => "ok " + i,
                string error => "error " + error,
            };
            Assert.Equal("ok 5", description);
        }

        [Fact]
        public void Existing_explicit_conversions_still_work()
        {
            Pet pet = new Cat("Tom");

            Assert.Equal(new Cat("Tom"), (Cat)pet);
        }
    }
}
