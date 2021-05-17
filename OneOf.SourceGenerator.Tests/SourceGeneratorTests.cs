using Xunit;

namespace OneOf.SourceGenerator.Tests
{
    public class SourceGeneratorTests
    {
        [Fact]
        public void GenerateOneOf_Generates_Correct_Classes_For_Simple_Types()
        {
            const string testName = "test";
            StringOrNumber stringOrNumber = testName;
            StringOrNumber stringOrNumberToCompare = testName;

            Assert.Equal(testName, stringOrNumber);
            Assert.Equal(stringOrNumberToCompare, stringOrNumber);
        }

    }

    [GenerateOneOf]
    public partial class StringOrNumber : OneOf.OneOfBase<System.String, System.Int32, System.UInt32> { }
}
