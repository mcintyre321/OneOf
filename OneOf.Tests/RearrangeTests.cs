using System.Globalization;
using NUnit.Framework;
using OneOf;

namespace OneOf.Tests
{
    public class RearrangeTests
    {
        [Test]
        public void CanRearrangeEquivalentOneOfValueTypesets()
        {
            OneOf<byte,short,int,long> value = 123;
            OneOf<long,int,short,byte> rearranged = OneOf<long,int,short,byte>.RearrangeFrom( value );

            bool isInt123 = false;
            rearranged.Switch(
                i64 => Assert.Fail(),
                i32 => isInt123 = true,
                i16 => Assert.Fail(),
                u8  => Assert.Fail()
            );

            Assert.IsTrue( isInt123 );
        }

        /* Uncomment this to reveal a compilation/intellisense error that `value` cannot be used as an argument for `RearrangeFrom`.

        [Test]
        public void CannotRearrangeOneOfValuesWithDifferentValueTypeSets()
        {
            OneOf<byte,short,int,long> value = 123;
            OneOf<long,int,string,byte> rearranged = OneOf<long,int,string,byte>.RearrangeFrom( value );

            bool isInt123 = false;
            rearranged.Switch(
                i64 => Assert.Fail(),
                i32 => isInt123 = true,
                i16 => Assert.Fail(),
                u8  => Assert.Fail()
            );

            Assert.IsTrue( isInt123 );
        }

        */
    }
}
