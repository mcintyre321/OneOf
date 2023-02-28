using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace OneOf.Serialization;

public class OneOfJsonConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
        => typeof(IOneOf).IsAssignableFrom(objectType);

    public override void WriteJson(
        JsonWriter writer,
        object value,
        JsonSerializer serializer
    )
    {
        var (oneOfGenericType, oneOfJsonGenericType) =
            GetTypes(value.GetType());
        if (oneOfGenericType is null)
            return;
        var oneOfJsonType = oneOfJsonGenericType
            .MakeGenericType(oneOfGenericType.GenericTypeArguments);
        var oneOfJson = Activator.CreateInstance(oneOfJsonType);
        var oneOfJsonIndex = ((dynamic)value).Index;
        var oneOfJsonValue = ((dynamic)value).Value;
        ((dynamic)oneOfJson).Index = oneOfJsonIndex;
        if (oneOfJsonIndex == 0)
            ((dynamic)oneOfJson).Value0 = oneOfJsonValue;
        if (oneOfJsonIndex == 1)
            ((dynamic)oneOfJson).Value1 = oneOfJsonValue;
        if (oneOfJsonIndex == 2)
            ((dynamic)oneOfJson).Value2 = oneOfJsonValue;
        if (oneOfJsonIndex == 3)
            ((dynamic)oneOfJson).Value3 = oneOfJsonValue;
        if (oneOfJsonIndex == 4)
            ((dynamic)oneOfJson).Value4 = oneOfJsonValue;
        if (oneOfJsonIndex == 5)
            ((dynamic)oneOfJson).Value5 = oneOfJsonValue;
        if (oneOfJsonIndex == 6)
            ((dynamic)oneOfJson).Value6 = oneOfJsonValue;
        if (oneOfJsonIndex == 7)
            ((dynamic)oneOfJson).Value7 = oneOfJsonValue;
        if (oneOfJsonIndex == 7)
            ((dynamic)oneOfJson).Value7 = oneOfJsonValue;
        if (oneOfJsonIndex == 8)
            ((dynamic)oneOfJson).Value8 = oneOfJsonValue;
        serializer.Serialize(writer, oneOfJson);
    }

    public override object ReadJson(
        JsonReader reader,
        Type objectType,
        object existingValue,
        JsonSerializer serializer
    )
    {
        var (oneOfGenericType, oneOfJsonGenericType) =
            GetTypes(objectType);
        if (oneOfGenericType is null)
            return null;

        var children = JObject.Load(reader).Children();
        var index = children.ElementAt(0).First.Value<int>();
        var type = oneOfGenericType.GenericTypeArguments[index];
        var value = children.ElementAt(index + 1).First.ToObject(type);

        if (false == _cache.TryGetValue((objectType, type), out var method))
        {
            method = objectType
                .GetMethods(BindingFlags.Static | BindingFlags.Public)
                .FirstOrDefault(x =>
                {
                    if (x.IsSpecialName == false)
                        return false;
                    if (x.Name != "op_Implicit" &&
                        x.Name != "op_Explicit")
                        return false;
                    var parameters = x.GetParameters();
                    if (parameters.Length != 1)
                        return false;
                    var parameter = parameters[0];
                    if (parameter.ParameterType != type)
                        return false;
                    return true;
                });
            if (method is null)
                throw new Exception("No compatible method was found.");
            _cache.TryAdd((objectType, type), method);
        }

        var result = method.Invoke(null, new object[] { value });
        return result;
    }

    private static readonly ConcurrentDictionary<(Type, Type), MethodInfo> _cache = new();

    private static (Type oneOfGenericType, Type oneOfJsonGenericType) GetTypes(Type type)
    {
        while (type is not null)
        {
            if (type.IsGenericType)
            {
                var genericTypeDefinition = type.GetGenericTypeDefinition();
                if (genericTypeDefinition == typeof(OneOfBase<,>) ||
                    genericTypeDefinition == typeof(OneOf<,>))
                    return (type, typeof(OneOfJson<,>));
                if (genericTypeDefinition == typeof(OneOfBase<,,>) ||
                    genericTypeDefinition == typeof(OneOf<,,>))
                    return (type, typeof(OneOfJson<,,>));
                if (genericTypeDefinition == typeof(OneOfBase<,,,>) ||
                    genericTypeDefinition == typeof(OneOf<,,,>))
                    return (type, typeof(OneOfJson<,,,>));
                if (genericTypeDefinition == typeof(OneOfBase<,,,,>) ||
                    genericTypeDefinition == typeof(OneOf<,,,,>))
                    return (type, typeof(OneOfJson<,,,,>));
                if (genericTypeDefinition == typeof(OneOfBase<,,,,,>) ||
                    genericTypeDefinition == typeof(OneOf<,,,,,>))
                    return (type, typeof(OneOfJson<,,,,,>));
                if (genericTypeDefinition == typeof(OneOfBase<,,,,,,>) ||
                    genericTypeDefinition == typeof(OneOf<,,,,,,>))
                    return (type, typeof(OneOfJson<,,,,,,>));
                if (genericTypeDefinition == typeof(OneOfBase<,,,,,,,>) ||
                    genericTypeDefinition == typeof(OneOf<,,,,,,,>))
                    return (type, typeof(OneOfJson<,,,,,,,>));
                if (genericTypeDefinition == typeof(OneOfBase<,,,,,,,,>) ||
                    genericTypeDefinition == typeof(OneOf<,,,,,,,,>))
                    return (type, typeof(OneOfJson<,,,,,,,,>));
            }
            type = type.BaseType;
        }
        return (null, null);
    }
}
