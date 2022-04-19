using NUnit.Framework;

namespace OneOf.Tests
{
    public class DeconstructTests
    {
        [Test]
        public void DeconstructT1()
        {
            OneOf<T1> oneOf = new T1();
            var (index, value) = oneOf;
            Assert.AreEqual(0, index);
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT2()
        {
            OneOf<T1, T2> oneOf = new T2();
            var (index,_, value) = oneOf;
            Assert.AreEqual(1, index);
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT3()
        {
            OneOf<T1, T2, T3> oneOf = new T3();
            var (index,_, _, value) = oneOf;
            Assert.AreEqual(2, index);
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT4()
        {
            OneOf<T1, T2, T3, T4> oneOf = new T4();
            var (index,_, _, _, value) = oneOf;
            Assert.AreEqual(3, index);
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT5()
        {
            OneOf<T1, T2, T3, T4, T5> oneOf = new T5();
            var (index,_, _, _, _, value) = oneOf;
            Assert.AreEqual(4, index);
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT6()
        {
            OneOf<T1, T2, T3, T4, T5, T6> oneOf = new T6();
            var (index,_, _, _, _, _, value) = oneOf;
            Assert.AreEqual(5, index);
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT7()
        {
            OneOf<T1, T2, T3, T4, T5, T6, T7> oneOf = new T7();
            var (index,_, _, _, _, _, _, value) = oneOf;
            Assert.AreEqual(6, index);
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT8()
        {
            OneOf<T1, T2, T3, T4, T5, T6, T7, T8> oneOf = new T8();
            var (index, _, _, _, _, _, _, _, value) = oneOf;
            Assert.AreEqual(7, index);
            Assert.IsNotNull(value);
        }
    }

    class T1
    {
    }

    class T2
    {
    }

    class T3
    {
    }

    class T4
    {
    }

    class T5
    {
    }

    class T6
    {
    }

    class T7
    {
    }

    class T8
    {
    }
}