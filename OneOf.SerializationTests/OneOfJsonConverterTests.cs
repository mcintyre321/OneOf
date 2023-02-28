using Newtonsoft.Json;
using NUnit.Framework;

namespace OneOf.Serialization.Tests;

[TestFixture()]
public class OneOfJsonConverterTests
{
    [Test()]
    public void OneOf_Test()
    {
        var oneOf = new OneOf<bool, char, int, decimal, string, Parent, Child[]>();
        var serialized = "";
        var deserialized = default(OneOf<bool, char, int, decimal, string, Parent, Child[]>);

        // bool
        oneOf = true;
        serialized = JsonConvert.SerializeObject(
            oneOf, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 0,
              "Value0": true,
              "Value1": "\u0000",
              "Value2": 0,
              "Value3": 0.0,
              "Value4": null,
              "Value5": null,
              "Value6": null
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject
            <OneOf<bool, char, int, decimal, string, Parent, Child[]>>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOf.Value, deserialized.Value);

        // char
        oneOf = 'A';
        serialized = JsonConvert.SerializeObject(
            oneOf, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 1,
              "Value0": false,
              "Value1": "A",
              "Value2": 0,
              "Value3": 0.0,
              "Value4": null,
              "Value5": null,
              "Value6": null
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject
            <OneOf<bool, char, int, decimal, string, Parent, Child[]>>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOf.Value, deserialized.Value);

        // int
        oneOf = 123;
        serialized = JsonConvert.SerializeObject(
            oneOf, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 2,
              "Value0": false,
              "Value1": "\u0000",
              "Value2": 123,
              "Value3": 0.0,
              "Value4": null,
              "Value5": null,
              "Value6": null
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject
            <OneOf<bool, char, int, decimal, string, Parent, Child[]>>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOf.Value, deserialized.Value);

        // decimal
        oneOf = 123.45m;
        serialized = JsonConvert.SerializeObject(
            oneOf, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 3,
              "Value0": false,
              "Value1": "\u0000",
              "Value2": 0,
              "Value3": 123.45,
              "Value4": null,
              "Value5": null,
              "Value6": null
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject
            <OneOf<bool, char, int, decimal, string, Parent, Child[]>>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOf.Value, deserialized.Value);

        // decimal
        oneOf = "lorem ipsum";
        serialized = JsonConvert.SerializeObject(
            oneOf, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 4,
              "Value0": false,
              "Value1": "\u0000",
              "Value2": 0,
              "Value3": 0.0,
              "Value4": "lorem ipsum",
              "Value5": null,
              "Value6": null
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject
            <OneOf<bool, char, int, decimal, string, Parent, Child[]>>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOf.Value, deserialized.Value);

        // Parent
        oneOf = new Parent()
        {
            foo = "Foo",
            bar = "Bar",
            child = new Child()
            {
                qux = "Qux",
            },
        };
        serialized = JsonConvert.SerializeObject(
            oneOf, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 5,
              "Value0": false,
              "Value1": "\u0000",
              "Value2": 0,
              "Value3": 0.0,
              "Value4": null,
              "Value5": {
                "foo": "Foo",
                "bar": "Bar",
                "child": {
                  "qux": "Qux"
                }
              },
              "Value6": null
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject
            <OneOf<bool, char, int, decimal, string, Parent, Child[]>>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOf.Value, deserialized.Value);

        // Child[]
        oneOf = new[]
        {
            new Child() { qux = "qux" },
            new Child() { qux = "QUX" },
        };
        serialized = JsonConvert.SerializeObject(
            oneOf, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 6,
              "Value0": false,
              "Value1": "\u0000",
              "Value2": 0,
              "Value3": 0.0,
              "Value4": null,
              "Value5": null,
              "Value6": [
                {
                  "qux": "qux"
                },
                {
                  "qux": "QUX"
                }
              ]
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject
            <OneOf<bool, char, int, decimal, string, Parent, Child[]>>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOf.Value, deserialized.Value);
    }

    [Test()]
    public void OneOfBase_Test()
    {
        var oneOfBase = default(MockOneOfBase);
        var serialized = "";
        var deserialized = default(MockOneOfBase);

        // bool
        oneOfBase = true;
        serialized = JsonConvert.SerializeObject(
            oneOfBase, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 0,
              "Value0": true,
              "Value1": "\u0000",
              "Value2": 0,
              "Value3": 0.0,
              "Value4": null,
              "Value5": null,
              "Value6": null
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject<MockOneOfBase>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOfBase.Value, deserialized.Value);

        // char
        oneOfBase = 'A';
        serialized = JsonConvert.SerializeObject(
            oneOfBase, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 1,
              "Value0": false,
              "Value1": "A",
              "Value2": 0,
              "Value3": 0.0,
              "Value4": null,
              "Value5": null,
              "Value6": null
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject<MockOneOfBase>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOfBase.Value, deserialized.Value);

        // int
        oneOfBase = 123;
        serialized = JsonConvert.SerializeObject(
            oneOfBase, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 2,
              "Value0": false,
              "Value1": "\u0000",
              "Value2": 123,
              "Value3": 0.0,
              "Value4": null,
              "Value5": null,
              "Value6": null
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject<MockOneOfBase>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOfBase.Value, deserialized.Value);

        // decimal
        oneOfBase = 123.45m;
        serialized = JsonConvert.SerializeObject(
            oneOfBase, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 3,
              "Value0": false,
              "Value1": "\u0000",
              "Value2": 0,
              "Value3": 123.45,
              "Value4": null,
              "Value5": null,
              "Value6": null
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject<MockOneOfBase>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOfBase.Value, deserialized.Value);

        // decimal
        oneOfBase = "lorem ipsum";
        serialized = JsonConvert.SerializeObject(
            oneOfBase, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 4,
              "Value0": false,
              "Value1": "\u0000",
              "Value2": 0,
              "Value3": 0.0,
              "Value4": "lorem ipsum",
              "Value5": null,
              "Value6": null
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject<MockOneOfBase>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOfBase.Value, deserialized.Value);

        // Parent
        oneOfBase = new Parent()
        {
            foo = "Foo",
            bar = "Bar",
            child = new Child()
            {
                qux = "Qux",
            },
        };
        serialized = JsonConvert.SerializeObject(
            oneOfBase, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 5,
              "Value0": false,
              "Value1": "\u0000",
              "Value2": 0,
              "Value3": 0.0,
              "Value4": null,
              "Value5": {
                "foo": "Foo",
                "bar": "Bar",
                "child": {
                  "qux": "Qux"
                }
              },
              "Value6": null
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject<MockOneOfBase>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOfBase.Value, deserialized.Value);

        // Child[]
        oneOfBase = new[]
        {
            new Child() { qux = "qux" },
            new Child() { qux = "QUX" },
        };
        serialized = JsonConvert.SerializeObject(
            oneOfBase, Formatting.Indented, new OneOfJsonConverter());
        Assert.AreEqual("""
            {
              "Index": 6,
              "Value0": false,
              "Value1": "\u0000",
              "Value2": 0,
              "Value3": 0.0,
              "Value4": null,
              "Value5": null,
              "Value6": [
                {
                  "qux": "qux"
                },
                {
                  "qux": "QUX"
                }
              ]
            }
            """, serialized);
        deserialized = JsonConvert.DeserializeObject<MockOneOfBase>(
            serialized, new OneOfJsonConverter());
        Assert.AreEqual(oneOfBase.Value, deserialized.Value);
    }
}

[GenerateOneOf()]
public partial class MockOneOfBase
    : OneOfBase<bool, char, int, decimal, string, Parent, Child[]>
{
}

public record Parent
{
    public string foo;
    public string bar;
    public Child child;
}
public record Child
{
    public string qux;
}
