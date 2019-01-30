using System.Globalization;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OneOf.Tests
{
    public class AsyncTests
    {
        [Test]
        public async Task MapAsync()
        {
            var resolvedDouble = await ResolveString(2.0);
            Assert.AreEqual("2", resolvedDouble);
            
            var resolvedInt = await ResolveString(4);
            Assert.AreEqual("4", resolvedInt);
            
            var resolvedString = await ResolveString("6");
            Assert.AreEqual("6", resolvedString);
        }
        
        [Test]
        public async Task SwitchAsync()
        {
            await AssertSwitch(2.0, "2");
            await AssertSwitch(4, "4");
            await AssertSwitch("6", "6");
        }
        
        private async Task<string> ResolveString(OneOf<double, int, string> input)
            => await input
                .MapT0(d => d.ToString(CultureInfo.InvariantCulture))
                .MapT1(i => i.ToString(CultureInfo.InvariantCulture))
                .MatchAsync(
                    t1 => Task.FromResult(t1),
                    t2 => Task.FromResult(t2),
                    t3 => Task.FromResult(t3)
                );
        
        private async Task AssertSwitch(OneOf<double, int, string> input, string expected)
            => await input
                .MapT0(d => d.ToString(CultureInfo.InvariantCulture))
                .MapT1(i => i.ToString(CultureInfo.InvariantCulture))
                .SwitchAsync(
                    async t1 =>
                    {
                        await Task.FromResult(0);
                        Assert.AreEqual(expected, t1);
                    },
                    async t2 =>
                    {
                        await Task.FromResult(0);
                        Assert.AreEqual(expected, t2);
                    },
                    async t3 =>
                    {
                        await Task.FromResult(0);
                        Assert.AreEqual(expected, t3);
                    }
                );
    }
}