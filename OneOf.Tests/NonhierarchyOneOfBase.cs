using NUnit.Framework;
using System;

namespace OneOf.Tests
{
    public class MetaValue : OneOfBase<string, bool, Random> 
    {
        public MetaValue(OneOf<string, bool, Random> input) : base(input) { }
    }

    public class MetaValue1 : OneOfBase<string, bool, Random>
    {
        public MetaValue1(string input) : base(input) { }
        public MetaValue1(bool input) : base(input) { }
        public MetaValue1(Random input) : base(input) { }
    }

    public class MetaValue2 : OneOfBase<string, MetaValue2.MetaValue2b, int>
    {
        protected MetaValue2() {}
        public MetaValue2(string s) : base(s) {}

        public class MetaValue2b : MetaValue2 {}

        public MetaValue2(int i) : base() {  }
    }

    public class NonhierarchyOneOfBaseTests
    {
        [Test]
        public void CanMatch() {
            var metaValue = new MetaValue("abcd");
            Assert.True(metaValue.IsT0);
            Assert.False(metaValue.IsT1);
            Assert.False(metaValue.IsT2);

            metaValue = new MetaValue(true);
            Assert.False(metaValue.IsT0);
            Assert.True(metaValue.IsT1);
            Assert.False(metaValue.IsT2);

            metaValue = new MetaValue(new Random());
            Assert.False(metaValue.IsT0);
            Assert.False(metaValue.IsT1);
            Assert.True(metaValue.IsT2);
        }

        [Test]
        public void CanMatchSeparateConstructors()
        {
            var metaValue = new MetaValue1("abcd");
            Assert.True(metaValue.IsT0);
            Assert.False(metaValue.IsT1);
            Assert.False(metaValue.IsT2);

            metaValue = new MetaValue1(true);
            Assert.False(metaValue.IsT0);
            Assert.True(metaValue.IsT1);
            Assert.False(metaValue.IsT2);

            metaValue = new MetaValue1(new Random());
            Assert.False(metaValue.IsT0);
            Assert.False(metaValue.IsT1);
            Assert.True(metaValue.IsT2);
        }

        [Test]
        public void CanMatchMixedDerivedNonderived() {
            MetaValue2 metaValue = new MetaValue2("abcd");
            Assert.True(metaValue.IsT0);
            Assert.False(metaValue.IsT1);

            metaValue = new MetaValue2.MetaValue2b();
            Assert.False(metaValue.IsT0);
            Assert.True(metaValue.IsT1);
        }

        public void NoParameterlessConstructorForNonderived() {
            Assert.Throws<InvalidOperationException>(() => new MetaValue2(5));
        }
    }
}
