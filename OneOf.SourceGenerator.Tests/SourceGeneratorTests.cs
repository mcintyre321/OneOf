using System;
using System.Collections.Generic;
using Xunit;

namespace OneOf.SourceGenerator.Tests
{
    public class SourceGeneratorTests
    {
        [Fact]
        public void GenerateOneOf_Generates_Correct_Classes_For_Struct_Types()
        {
            const string testName = "test";
            const int testNumber = 3;

            StringOrNumber stringOrNumber = testName;
            StringOrNumber stringOrNumberToCompare = testName;

            Assert.Equal(testName, stringOrNumber);
            Assert.Equal(stringOrNumberToCompare, stringOrNumber);

            stringOrNumber = testNumber;
            stringOrNumberToCompare = testNumber;

            Assert.Equal(testNumber, (int)stringOrNumber);
            Assert.True(testNumber == (int)stringOrNumber);
            Assert.Equal(stringOrNumberToCompare, stringOrNumber);
        }

        [Fact]
        public void GenerateOneOf_Can_Assign_To_Struct_Type()
        {
            const string testName = "test";

            StringOrNumber stringOrNumber = testName;

            string name = (string)stringOrNumber;

            Assert.Equal(testName, name);
        }

        [Fact]
        public void GenerateOneOf_Generates_Correct_Classes_For_Referance_Types()
        {
            MyClass testclass = new();
            MyClass2 testclass2 = new();

            MyClass2OrMyClass myClass2OrMyClass = testclass;
            MyClass2OrMyClass myClass2OrMyClassToCompare = testclass;

            Assert.Equal(testclass, (MyClass)myClass2OrMyClass);
            Assert.Equal((MyClass)myClass2OrMyClass, (MyClass)myClass2OrMyClassToCompare);

            myClass2OrMyClass = testclass2;
            myClass2OrMyClassToCompare = testclass2;

            Assert.Equal(testclass2, (MyClass2)myClass2OrMyClass);
            Assert.Equal((MyClass2)myClass2OrMyClass, (MyClass2)myClass2OrMyClassToCompare);
        }

        [Fact]
        public void GenerateOneOf_Can_Assign_To_Referance_Type()
        {
            MyClass testClass = new();

            MyClass2OrMyClass myClass2OrMyClass = testClass;

            var test = (MyClass)myClass2OrMyClass;

            Assert.Equal(testClass, test);
        }

        [Fact]
        public void GenerateOneOf_Works_With_Class_Names_Conflicts()
        {
            NotOneOf.OneOf notOneOf = new();

            MyClassOrFakeOneOf myClass2OrFakeOneOf = notOneOf;

            var test = (NotOneOf.OneOf)myClass2OrFakeOneOf;

            Assert.Equal(notOneOf, test);
        }

        [Fact]
        public void GenerateOneOf_Works_With_Simple_Generic_Types()
        {
            SimpleGeneric simple1 = new List<string> { "a", "b", "c" };
            Assert.True(simple1.IsT0);

            SimpleGeneric simple2 = new List<int> { 1, 2, 3 };
            Assert.True(simple2.IsT1);

            SimpleGeneric simple3 = new Dictionary<long, string> { { 1, "a" }, { 2, "b" }, { 3, "c" } };
            Assert.True(simple3.IsT2);
        }

        [Fact]
        public void GenerateOneOf_Works_With_Nested_Generics()
        {
            NestedGeneric nested1 = new List<List<string>> { new() { "a", "b", "c" } };
            Assert.True(nested1.IsT0);

            NestedGeneric nested2 = new Dictionary<List<string>, string> { { new List<string> { "a", "b", "c" }, "d" } };
            Assert.True(nested2.IsT2);
        }

        [Fact]
        public void GenerateOneOf_Generates_NamedProperties_Is()
        {
            SuccessOrFailureOrInt32OrBool succ = new SuccessOrFailureOrInt32OrBool.Success();
            Assert.True(succ.IsSuccess);
            Assert.False(succ.IsFailure);
            Assert.False(succ.IsInt32);
            Assert.False(succ.IsBoolean);

            SuccessOrFailureOrInt32OrBool fail = new SuccessOrFailureOrInt32OrBool.Failure();
            Assert.False(fail.IsSuccess);
            Assert.True(fail.IsFailure);
            Assert.False(succ.IsInt32);
            Assert.False(succ.IsBoolean);

            SuccessOrFailureOrInt32OrBool i32 = 9;
            Assert.False(i32.IsSuccess);
            Assert.False(i32.IsFailure);
            Assert.True(i32.IsInt32);
            Assert.False(i32.IsBoolean);

            SuccessOrFailureOrInt32OrBool b = true;
            Assert.False(b.IsSuccess);
            Assert.False(b.IsFailure);
            Assert.False(b.IsInt32);
            Assert.True(b.IsBoolean);
        }

        [Fact]
        public void GenerateOneOf_Generates_NamedProperties_As()
        {
            SuccessOrFailureOrInt32OrBool succ = new SuccessOrFailureOrInt32OrBool.Success();
            Assert.NotNull(succ.AsSuccess);
            Assert.Throws<InvalidOperationException>(() => succ.AsFailure);
            Assert.Throws<InvalidOperationException>(() => succ.AsInt32);
            Assert.Throws<InvalidOperationException>(() => succ.AsBoolean);

            SuccessOrFailureOrInt32OrBool fail = new SuccessOrFailureOrInt32OrBool.Failure();
            Assert.Throws<InvalidOperationException>(() => fail.AsSuccess);
            Assert.NotNull(fail.AsFailure);
            Assert.Throws<InvalidOperationException>(() => fail.AsInt32);
            Assert.Throws<InvalidOperationException>(() => fail.AsBoolean);

            SuccessOrFailureOrInt32OrBool i32 = 9;
            Assert.Throws<InvalidOperationException>(() => i32.AsSuccess);
            Assert.Throws<InvalidOperationException>(() => i32.AsFailure);
            Assert.Equal(9, i32.AsInt32);
            Assert.Throws<InvalidOperationException>(() => i32.AsBoolean);

            SuccessOrFailureOrInt32OrBool b = true;
            Assert.Throws<InvalidOperationException>(() => b.AsSuccess);
            Assert.Throws<InvalidOperationException>(() => b.AsFailure);
            Assert.Throws<InvalidOperationException>(() => b.AsInt32);
            Assert.True(b.AsBoolean);
        }
    }

    [GenerateOneOf]
    public partial class NestedGeneric : OneOfBase<List<List<string>>, List<int>, Dictionary<List<string>, string>> { }

    [GenerateOneOf]
    public partial class SimpleGeneric : OneOfBase<List<string>, List<int>, Dictionary<long, string>> { }

    [GenerateOneOf]
    public partial class StringOrNumber : OneOfBase<string, int, uint> { }

    [GenerateOneOf]
    public partial class MyClass2OrMyClass : OneOfBase<MyClass, MyClass2> { }

    [GenerateOneOf]
    public partial class MyClassOrFakeOneOf : OneOfBase<MyClass, NotOneOf.OneOf> { }

    [GenerateOneOf(GenerateNamedProperties = true)]
    public partial class SuccessOrFailureOrInt32OrBool : OneOfBase<
        SuccessOrFailureOrInt32OrBool.Success,
        SuccessOrFailureOrInt32OrBool.Failure,
        Int32,
        bool>
    {
        public class Success { }
        public class Failure { }
    }

    public class MyClass
    {

    }

    public class MyClass2
    {

    }
}

namespace NotOneOf
{
    public class OneOf
    {

    }
}
