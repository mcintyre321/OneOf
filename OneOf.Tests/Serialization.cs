using Newtonsoft.Json;
using NUnit.Framework;

namespace OneOf.Tests
{
    public class Serialization
    {
        [Test]
        public void CanSerializeOneOfValueTransparently()
        {
            //Given an object with a OneOf property 
            var x = new SomeThing
                    {
                        Value = "A string value"
                    };
            //When that object is serialized
            var json = JsonConvert.SerializeObject(x, new JsonSerializerSettings
                                                      {
                                                          Converters = { new OneOfJsonConverter() }
                                                      });

            //Then the OneOfs underlying value should have been written
            Assert.AreEqual("{\"Value\":\"A string value\"}", json);
        }
    }

    class SomeThing
    {
        public OneOf<string, SomeOtherThing> Value { get; set; }
    }

    internal class SomeOtherThing
    {
        public int Value { get; set; }
    }
}
