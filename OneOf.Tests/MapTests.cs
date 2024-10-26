using System;
using System.Globalization;
using System.Threading.Tasks;
using NUnit.Framework;
using OneOf;

namespace OneOf.Tests
{
    public class MapTests
    {
        [Test]
        public void MapValue()
        {
            var resolvedDouble = ResolveString(2.0);
            var resolveInt = ResolveString(4);
            var resolveString = ResolveString("6");
        }

        [Test]
        [TestCase(2.1, ExpectedResult = "2.1")]
        [TestCase(4, ExpectedResult = "4")]
        [TestCase("6", ExpectedResult = "6")]
        public async Task<string> MapValueAsync<T>(T value) 
        {
            OneOf<double, int, string> oneOf = value switch
            {
                double v => v,
                int v => v,
                string v => v,
                _ => throw new InvalidOperationException("Invalid value type for this OneOf type")
            };
            
            return await ResolveStringAsync(oneOf);
        }

        private string ResolveString(OneOf<double, int, string> input)
            => input
                .MapT0(d => d.ToString(CultureInfo.InvariantCulture))
                .MapT1(i => i.ToString(CultureInfo.InvariantCulture))
                .Match(t1 => t1, t2 => t2, t3 => t3);

        private async Task<string> ResolveStringAsync(OneOf<double, int, string> input)
        {
            var map1 = await input.MapT0Async(d => Task.FromResult(d.ToString(CultureInfo.InvariantCulture)));
            var map2 = await map1.MapT1Async(i => Task.FromResult(i.ToString(CultureInfo.InvariantCulture)));
            return await map2.MatchAsync(t1 => Task.FromResult(t1), t2 => Task.FromResult(t2), t3 => Task.FromResult(t3));
        }
    }
}
