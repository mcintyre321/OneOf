using System;
using System.Globalization;
using System.Threading.Tasks;
using NUnit.Framework;
using OneOf;

namespace OneOf.Tests
{
    public class SwitchTests
    {
        private class SwitchAsyncException : Exception
        {

        }

        [Test]
        public async Task SwitchAsync()
        {
            OneOf<int, float> oneof = 10f;
            string result = string.Empty;

            await oneof.Switch(async f0 =>
            {
                result = await DoWorkAsync(f0);
            }, async f1 =>
            {
                result = await DoWorkAsync(f1);
            });

            Assert.AreEqual("10.00", result);

            Assert.ThrowsAsync<SwitchAsyncException>(async () =>
            {
                await oneof.Switch(async f0 =>
                {
                    result = await DoWorkAsync(f0);
                }, async f1 =>
                {
                    result = await DoWorkWithErrorAsync(f1);
                });

            });
        }

        private string ResolveString(OneOf<double, int, string> input)
            => input
                .MapT0(d => d.ToString(CultureInfo.InvariantCulture))
                .MapT1(i => i.ToString(CultureInfo.InvariantCulture))
                .Match(t1 => t1, t2 => t2, t3 => t3);

        private Task<string> DoWorkAsync(int value)
        {
            return Task.FromResult(value.ToString());
        }

        private Task<string> DoWorkAsync(float value)
        {
            return Task.FromResult(value.ToString("N"));
        }

        private Task<string> DoWorkWithErrorAsync(float value)
        {
            throw new SwitchAsyncException();
        }
    }
}
