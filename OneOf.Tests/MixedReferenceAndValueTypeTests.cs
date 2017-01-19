using NUnit.Framework;
using OneOf;

namespace OneOf.Tests
{
    public class RetryStrategy : OneOfBase<RetryStrategy.Never, int>
    {
        private RetryStrategy() { }
        private RetryStrategy(int attempts):base(1, value1:attempts) { }

        public static implicit operator RetryStrategy(int attempts)
        {
            return new RetryStrategy(attempts);
        }
        public class Never : RetryStrategy
        {
            internal int _attempts = 0;
        }

        public int Attempts => Match(n => n._attempts, n => n);
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
