using Newtonsoft.Json;
using NUnit.Framework;

namespace OneOf.Tests
{
	public class OneOfBaseSerialization
	{
		[Test]
		public void CanSerializeOneOfBaseValueTransparently()
		{
			//Given an object with a OneOf property 
			var x = new SomeBaseThing.SomeConcreteThing{Value = "Some value"};

			//When that object is serialized
			var jsonSerializerSettings = new JsonSerializerSettings
			{
				Converters = {new OneOfJsonConverter()}
			};
			var json = JsonConvert.SerializeObject(x, jsonSerializerSettings);
			var x2 = JsonConvert.DeserializeObject<SomeBaseThing.SomeConcreteThing>(json, jsonSerializerSettings);
			Assert.AreEqual(x.Value, x2.Value);
		}
	}

	public abstract class SomeBaseThing : OneOfBase<SomeBaseThing.SomeConcreteThing>
	{
		public class SomeConcreteThing : SomeBaseThing
		{
			public string Value { get; set; }
		}
	}
}