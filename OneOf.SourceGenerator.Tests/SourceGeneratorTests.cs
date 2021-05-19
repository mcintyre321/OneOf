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

            Assert.Equal<int>(testNumber, stringOrNumber);
            Assert.True(testNumber == stringOrNumber);
            Assert.Equal(stringOrNumberToCompare, stringOrNumber);
        }

        [Fact]
        public void GenerateOneOf_Can_Assign_To_Struct_Type()
        {
            const string testName = "test";

            StringOrNumber stringOrNumber = testName;

            string name = stringOrNumber;

            Assert.Equal(testName, name);
        }

        [Fact]
        public void GenerateOneOf_Generates_Correct_Classes_For_Referance_Types()
        {
            MyClass testclass = new();
            MyClass2 testclass2 = new();

            MyClass2OrMyClass myClass2OrMyClass = testclass;
            MyClass2OrMyClass myClass2OrMyClassToCompare = testclass;

            Assert.Equal<MyClass>(testclass, myClass2OrMyClass);
            Assert.Equal<MyClass>(myClass2OrMyClass, myClass2OrMyClassToCompare);

            myClass2OrMyClass = testclass2;
            myClass2OrMyClassToCompare = testclass2;

            Assert.Equal<MyClass2>(testclass2, myClass2OrMyClass);
            Assert.Equal<MyClass2>(myClass2OrMyClass, myClass2OrMyClassToCompare);
        }

        [Fact]
        public void GenerateOneOf_Can_Assign_To_Referance_Type()
        {
            MyClass testClass = new();

            MyClass2OrMyClass myClass2OrMyClass = testClass;

            MyClass test = myClass2OrMyClass;

            Assert.Equal(testClass, test);
        }
    }

    [GenerateOneOf]
    public partial class StringOrNumber : OneOf.OneOfBase<System.String, System.Int32, System.UInt32> { }

    [GenerateOneOf]
    public partial class MyClass2OrMyClass : OneOf.OneOfBase<MyClass, MyClass2> { }

    public class MyClass
    {

    }

    public class MyClass2
    {

    }
}
