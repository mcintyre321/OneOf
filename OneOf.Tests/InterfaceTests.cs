using NUnit.Framework;
using OneOf;

namespace OneOf.Tests
{
    public class InterfaceTests
    {
        [Test]
        public void ResolveIFooFromResultMethod()
        {
            var result = OneOf<IFoo, int>.Result(new Foo());
        }
    }

    public class Foo : IFoo
    {
        
    }
    public interface IFoo
    {
        
    }
}
