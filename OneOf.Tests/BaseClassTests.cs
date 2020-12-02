using NUnit.Framework;

namespace OneOf.Tests {
    public class Response : OneOfBase<
        Response.MethodNotAllowed,
        Response.InvokeSuccessResponse
        >
    {
        Response(OneOf<MethodNotAllowed, InvokeSuccessResponse> _) : base(_) { }
        public class MethodNotAllowed {}
        public class InvokeSuccessResponse {}

        public static implicit operator Response(MethodNotAllowed _) => new Response(_);
        public static implicit operator Response(InvokeSuccessResponse _) => new Response(_);
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
