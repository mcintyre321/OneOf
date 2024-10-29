using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneOf.Tests
{
    public class TypecastTests
    {
        class IntHolder { public int Value { get; set; } }
        class StringHolder { public string Value { get; set; } }
        class DoubleHolder{ public double Value { get; set; } }
        class NothingHolder { }
        class NothingHolder2 { }
        class NothingHolder3 { }
        class NothingHolder4 { }
        class NothingHolder5 { }
        class NothingHolder6 { }

        [Test]
        public void CanCastToOneOf()
        {
            var expected = "Hello, world.";
            OneOf<NothingHolder, StringHolder, IntHolder> actual = new StringHolder { Value = expected };
            Assert.AreEqual(actual.AsT1.Value, expected);
        }

        [Test]
        public void CanCastToLargerOneOf()
        {
            var expected = 99;
            var initial = OneOf<StringHolder, IntHolder>.FromT1(new IntHolder { Value = expected });
            OneOf<StringHolder, IntHolder, NothingHolder, NothingHolder2, NothingHolder3, NothingHolder4, NothingHolder5, NothingHolder6> actual = initial;
            Assert.AreEqual(actual.AsT1.Value, expected);
        }
    }
}