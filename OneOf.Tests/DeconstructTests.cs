using NUnit.Framework;

namespace OneOf.Tests
{
    public class DeconstructTests
    {
        [Test]
        public void DeconstructT1()
        {
            OneOf<T1> oneOf = new T1();
            var (value) = oneOf;
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT2()
        {
            OneOf<T1, T2> oneOf = new T2();
            var (_, value) = oneOf;
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT3()
        {
            OneOf<T1, T2, T3> oneOf = new T3();
            var (_, _, value) = oneOf;
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT4()
        {
            OneOf<T1, T2, T3, T4> oneOf = new T4();
            var (_, _, _, value) = oneOf;
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT5()
        {
            OneOf<T1, T2, T3, T4, T5> oneOf = new T5();
            var (_, _, _, _, value) = oneOf;
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT6()
        {
            OneOf<T1, T2, T3, T4, T5, T6> oneOf = new T6();
            var (_, _, _, _, _, value) = oneOf;
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT7()
        {
            OneOf<T1, T2, T3, T4, T5, T6, T7> oneOf = new T7();
            var (_, _, _, _, _, _, value) = oneOf;
            Assert.IsNotNull(value);
        }
        
        [Test]
        public void DeconstructT8()
        {
            OneOf<T1, T2, T3, T4, T5, T6, T7, T8> oneOf = new T8();
            var (_, _, _, _, _, _, _, value) = oneOf;
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