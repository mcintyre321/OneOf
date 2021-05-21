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
    }

    [GenerateOneOf]
    public partial class StringOrNumber : OneOfBase<string, int, uint> { }

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
}

namespace NotOneOf
{
    public class OneOf
    {

    }
}
