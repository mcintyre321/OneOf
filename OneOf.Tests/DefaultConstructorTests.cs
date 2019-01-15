using NUnit.Framework;
using OneOf;

namespace OneOf.Tests
{
    public class DefaultConstructorTests
    {
        [Test]
        public void DefaultConstructorSetsValueToDefaultValueOfT0()
        {
            var x = new OneOf<int, bool>();
            var result = x.Match(n => n == default(int), n => false);
        }
    }
}
