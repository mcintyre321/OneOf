using NUnit.Framework;
using OneOf;

namespace OneOf.Tests
{
    using System;

    public class DefaultConstructorTests
    {
        [Test]
        public void DefaultValueIsUndefined()
        {
            var value = default(OneOf<int>);

            Assert.IsFalse(value.IsT0);
            Assert.Throws<InvalidOperationException>(
                () =>
                {
                    var unused = value.Value;
                });
            Assert.Throws<InvalidOperationException>(
                () =>
                {
                    var unused = value.AsT0;
                });
        }
    }
}
