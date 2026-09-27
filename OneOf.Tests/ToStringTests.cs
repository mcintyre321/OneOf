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

        // The exact date format differs between Windows (NLS) and ICU, so compare against the
        // runtime's own formatting in that culture rather than a hard-coded string.
        static string ExpectedDate(string cultureName) =>
            RunInCulture(new CultureInfo(cultureName, false), () => "System.DateTime: " + new DateTime(2019, 1, 2, 1, 2, 3));

        [TestCase("en-NZ")]
        [TestCase("en-US")]
        public void LeftSideFormatsWithCurrentCulture(string cultureName)
        {
            var result = RunInCulture(new CultureInfo(cultureName, false), () =>
            {
                OneOf<DateTime, string> a = new DateTime(2019, 1, 2, 1, 2, 3);
                return a.ToString();
            });
            Assert.AreEqual(ExpectedDate(cultureName), result);
        }

        [Test]
        public void DateFormattingFollowsCurrentCulture() =>
            Assert.AreNotEqual(ExpectedDate("en-NZ"), ExpectedDate("en-US"));

        [TestCase("en-NZ")]
        [TestCase("en-US")]
        public void RightSideFormatsWithCurrentCulture(string cultureName)
        {
            var result = RunInCulture(new CultureInfo(cultureName, false), () =>
            {
                OneOf<string, DateTime> a = new DateTime(2019, 1, 2, 1, 2, 3);
                return a.ToString();
            });
            Assert.AreEqual(ExpectedDate(cultureName), result);
        }

        [Test]
        public void TheValueAndTypeNameAreFormattedCorrectly()
        {
            OneOf<string, int, DateTime, decimal> a = 42;
            Assert.AreEqual("System.Int32: 42", a.ToString());
        }

        public class RecursiveOneOf : OneOfBase<RecursiveOneOf.InnerOne, RecursiveOneOf.InnerTwo>
        {
            RecursiveOneOf(OneOf<InnerOne, InnerTwo> _) : base(_) { }
            public class InnerOne { }
            public class InnerTwo { }
        }

        [Test]
        public void CallingToStringOnARecursiveTypeWorks()
        {
            var innerTypeOfRecursiveOneOf = new RecursiveOneOf.InnerOne();

            Assert.AreEqual("OneOf.Tests.ToStringTests+RecursiveOneOf+InnerOne", innerTypeOfRecursiveOneOf.ToString());
        }

        [Test]
        public void CallingToStringOnANestedNonRecursiveTypeWorks()
        {
            OneOf<OneOf<string, bool>, OneOf<bool, string>> nestedType = (OneOf<string, bool>)true;

            Assert.AreEqual(typeof(OneOf<string, bool>).FullName + ": System.Boolean: True", nestedType.ToString());
        }
    }
}
