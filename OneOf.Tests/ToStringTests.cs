using System;
using System.Globalization;
using System.Threading;
using NUnit.Framework;

namespace OneOf.Tests
{
    public class ToStringTests
    {
        static string RunInCulture(CultureInfo culture, Func<string> action)
        {
            var originalCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = culture;
            try
            {
                return action();
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = originalCulture;
            }
        }

        [TestCase("en-NZ", ExpectedResult = "System.DateTime: 2/01/2019 1:02:03 AM")]
        [TestCase("en-US", ExpectedResult = "System.DateTime: 1/2/2019 1:02:03 AM")]
        public string LeftSideFormatsWithCurrentCulture(string cultureName)
        {
            return RunInCulture(new CultureInfo(cultureName, false), () =>
            {
                OneOf<DateTime, string> a = new DateTime(2019, 1, 2, 1, 2, 3);
                return a.ToString();
            });
        }

        [TestCase("en-NZ", ExpectedResult = "System.DateTime: 2/01/2019 1:02:03 AM")]
        [TestCase("en-US", ExpectedResult = "System.DateTime: 1/2/2019 1:02:03 AM")]
        public string RightSideFormatsWithCurrentCulture(string cultureName)
        {
            return RunInCulture(new CultureInfo(cultureName, false), () =>
            {
                OneOf<string, DateTime> a = new DateTime(2019, 1, 2, 1, 2, 3);
                return a.ToString();
            });
        }

        [Test]
        public void TheValueAndTypeNameAreFormattedCorrectly()
        {
            OneOf<string, int, DateTime, decimal> a = 42;
            Assert.AreEqual("System.Int32: 42", a.ToString());
        }
    }
}
