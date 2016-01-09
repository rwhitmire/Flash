using System.Web.Mvc;
using Xunit;

namespace Flash.Mvc5.Test
{
    public class RequestExtensionsTest
    {
        [Fact]
        public void FlashShouldAddMessagesToSession()
        {
            var request = TestHelpers.GetMockRequest();
            request.Flash("success", "success message");
            request.Flash("error", "error message");
            var messages = request.GetFlashMessages();
            Assert.Equal(2, messages.Count);
        }
    }
}
