using System.Globalization;
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

        private string ResolveString(OneOf<double, int, string> input)
            => input
                .MapT0(d => d.ToString(CultureInfo.InvariantCulture))
                .MapT1(i => i.ToString(CultureInfo.InvariantCulture))
                .Match(t1 => t1, t2 => t2, t3 => t3);
    }
}
