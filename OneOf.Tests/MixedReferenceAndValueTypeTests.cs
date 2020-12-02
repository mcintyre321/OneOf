using NUnit.Framework;

namespace OneOf.Tests 
{
    public class RetryStrategy : OneOfBase<RetryStrategy.Never, int>
    {
        RetryStrategy(OneOf<Never, int> _) : base(_) { }

        public class Never {
            internal int _attempts = 0;
        }

        public int Attempts => Match(n => n._attempts, n => n);

        public static implicit operator RetryStrategy(Never never) => new RetryStrategy(never);
        public static implicit operator RetryStrategy(int attempts) => new RetryStrategy(attempts);
    }

    public class MixedReferenceAndValueTypeTests
    {
        [Test]
        public void CanMatchOnReferenceAndValue()
        {
            RetryStrategy strat = 5;
            Assert.AreEqual(strat.Attempts, 5);
            strat = new RetryStrategy.Never();
            Assert.AreEqual(strat.Attempts, 0);
        }
    }
}
