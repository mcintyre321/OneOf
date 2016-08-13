using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OneOf.Tests
{
    public abstract class Response : OneOfBase<
        Response.MethodNotAllowed,
        Response.InvokeSuccessResponse
        >
    {

        public class MethodNotAllowed : Response
        {
        }

        public class InvokeSuccessResponse : Response
        {
        }

    }

    public class BaseClassTests
    {
        [Test]
        public void CanMatchOnBase()
        {
            Response x = new Response.MethodNotAllowed();
            Assert.AreEqual(true, x.Match(
                allowed => true,
                response => false));
        }
    }

}
