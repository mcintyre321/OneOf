using NUnit.Framework;
using OneOf;

namespace OneOf.Tests
{
    public class EqualsTests
    {
        [Test]
        public void AreEqual()
        {
            OneOf<int> a = 1;
            OneOf<int> b = a;
            Assert.IsTrue(a.Equals(b));
        }
    }
}
