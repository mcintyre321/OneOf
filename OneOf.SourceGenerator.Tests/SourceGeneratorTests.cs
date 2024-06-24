using System.Collections.Generic;
using OneOf;
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
        public void GenerateOneOf_Generates_Correct_Classes_For_Reference_Types()
        {
            MyClass testClass = new();
            MyClass2 testClass2 = new();

            MyClass2OrMyClass myClass2OrMyClass = testClass;
            MyClass2OrMyClass myClass2OrMyClassToCompare = testClass;

            Assert.Equal(testClass, (MyClass)myClass2OrMyClass);
            Assert.Equal((MyClass)myClass2OrMyClass, (MyClass)myClass2OrMyClassToCompare);

            myClass2OrMyClass = testClass2;
            myClass2OrMyClassToCompare = testClass2;

            Assert.Equal(testClass2, (MyClass2)myClass2OrMyClass);
            Assert.Equal((MyClass2)myClass2OrMyClass, (MyClass2)myClass2OrMyClassToCompare);
        }

        [Fact]
        public void GenerateOneOf_Can_Assign_To_Reference_Type()
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
        public void GenerateOneOf_Works_With_Open_Generics_With_Records()
        {
            OpenGenericWithRecords<MyClass, MyClass2> open = new Ok<MyClass>(new MyClass());
            Assert.True(open.IsT0);

            OpenGenericWithRecords<MyClass, MyClass2> open2 = new Error<MyClass2>(new MyClass2());
            Assert.True(open2.IsT1);
        }

        [Fact]
        public void GenerateOneOf_Works_With_Open_Generics_And_Nested_Generics()
        {
            OpenGenericWithRecords<List<int>, MyClass2> open = new Ok<List<int>>(new List<int> { 1, 2, 3 });
            Assert.True(open.IsT0);
        }

        [Fact]
        public void GenerateOneOf_Works_With_Open_And_Closed_Generics()
        {
            OpenGenericWithClosed<MyClass> openWithClosed = new Ok<MyClass>(new MyClass());
            Assert.True(openWithClosed.IsT0);

            OpenGenericWithClosed<MyClass2> openWithClosed2 = new MyClass();
            Assert.True(openWithClosed2.IsT1);
        }

        [Fact]
        public void GenerateOneOf_Works_WithTypesFromOneOfNameSpace()
        {
            DifferentLibrary.OneOf.JustLibraryClass justLibraryClass = new DifferentLibrary.OneOf.LibraryClass();
            Assert.True(justLibraryClass.IsT0);
        }
    }

    [GenerateOneOf]
    public partial class NestedGeneric : OneOfBase<List<List<string>>, List<int>, Dictionary<List<string>, string>> { }

    [GenerateOneOf]
    public partial class SimpleGeneric : OneOfBase<List<string>, List<int>, Dictionary<long, string>> { }

    [GenerateOneOf]
    internal partial class StringOrNumber : OneOfBase<string, int, uint> { }

    [GenerateOneOf]
    public partial class MyClass2OrMyClass : OneOfBase<MyClass, MyClass2> { }

    [GenerateOneOf]
    public partial class MyClassOrFakeOneOf : OneOfBase<MyClass, NotOneOf.OneOf> { }

    public class MyClass
    {

    }

    public class MyClass2
    {

    }

    public record Error<TError>
    (
        TError ErrorData
    );

    public record Ok<TResult>
    (
        TResult Data
    );

    [GenerateOneOf]
    public partial class OpenGenericWithRecords<TOk, TError> : OneOfBase<Ok<TOk>, Error<TError>>
    {
    }

    [GenerateOneOf]
    public partial class OpenGenericWithClosed<TOk> : OneOfBase<Ok<TOk>, MyClass>
    {
    }
}

namespace NotOneOf
{
    public class OneOf
    {

    }
}

namespace DifferentLibrary.OneOf
{
    public class LibraryClass
    {
    }

    [GenerateOneOf]
    public partial class JustLibraryClass : OneOfBase<LibraryClass>
    {
    }
}
