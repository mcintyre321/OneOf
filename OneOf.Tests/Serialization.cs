using OneOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
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
            var x = new SomeThing()
            {
                Value = "A string value"
            };
            //When that object is serialized
            var json = JsonConvert.SerializeObject(x);

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
