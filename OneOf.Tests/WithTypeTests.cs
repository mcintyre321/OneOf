using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneOf.Tests {
    public class WithTypeTests {
        [Test]
        public void WithType() {
            var example = OneOf<int, long, double, char>.FromT2(5.0);
            var result = example.WithType<string>();
            Assert.AreEqual(result.Value, 5.0); 
            Assert.AreEqual(result.Value, example.Value);
            Assert.AreEqual(result.Index, example.Index);
            Assert.IsTrue(result.IsT2);
            Assert.IsFalse(result.IsT4);
        }

        #region the example code from the readme
        public OneOf<string, double> ParseDouble(string input) {
            if (double.TryParse(input, out var result)) {
                return result;
            } else {
                return input;
            }
        }

        public OneOf<string, double, DateTime, int> ParseDoubleOrUTCDateOrInt(string input) {
            if (DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out var dateResult)) {
                return dateResult;
            }
            else if (int.TryParse(input, out var intResult)) {
                return intResult;
            } else {
                return ParseDouble(input).WithType<DateTime>().WithType<int>();
            }
        }

        [Test]
        public void TestParseDoubleOrUTCDateOrInt() {
            Assert.AreEqual(ParseDoubleOrUTCDateOrInt("fred").AsT0, "fred");
            Assert.AreEqual(ParseDoubleOrUTCDateOrInt("5.5").AsT1, 5.5);
            Assert.AreEqual(ParseDoubleOrUTCDateOrInt("2000-01-01").AsT2, new DateTime(2000, 01, 01, 0, 0, 0, DateTimeKind.Unspecified));
            Assert.AreEqual(ParseDoubleOrUTCDateOrInt("999").AsT3, 999);
        }
        #endregion
    }
}
