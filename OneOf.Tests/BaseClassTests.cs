using NUnit.Framework;

namespace OneOf.Tests
{
    [TestFixture]
    public abstract class Response : OneOfBase<
        Response.MethodNotAllowed,
        Response.InvokeSuccessResponse
    >
    {
        public class MethodNotAllowed : Response { }

        public class InvokeSuccessResponse : Response { }
    }

    public class BaseClassTests
    {
        [Test]
        public void CanMatchOnBase()
        {
            Response x = new Response.MethodNotAllowed();
            Assert.AreEqual(true, x.Match(
                                          methodNotAllowed => true,
                                          invokeSuccessResponse => false));
        }
    }
}
