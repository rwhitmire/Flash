using System.Web;
using System.Web.Routing;
using Moq;

namespace Flash.Mvc5.Test
{
    public static class TestHelpers
    {
        public static HttpRequestBase GetMockRequest()
        {
            var mockRequest = new Mock<HttpRequestBase>();
            var mockHttpContextBase = new Mock<HttpContextBase>();
            var mockRequestContext = new Mock<RequestContext>();
            mockHttpContextBase.SetupGet(x => x.Session).Returns(new MockSession());
            mockRequestContext.SetupGet(x => x.HttpContext).Returns(mockHttpContextBase.Object);
            mockRequest.SetupGet(x => x.RequestContext).Returns(mockRequestContext.Object);
            return mockRequest.Object;
        }
    }
}