using System.Collections.Generic;

namespace System.Web.Mvc
{
    public static class RequestExtensions
    {
        private const string SESSION_KEY = "flash_messages";

        /// <summary>
        /// Add a flash message to session
        /// </summary>
        /// <param name="request">HttpRequestBase</param>
        /// <param name="type">message type</param>
        /// <param name="message">message content</param>
        public static void Flash(this HttpRequestBase request, string type, string message)
        {
            var session = request.RequestContext.HttpContext.Session;
            var messages = new FlashMessages();

            if (session[SESSION_KEY] != null)
            {
                messages = (FlashMessages) session[SESSION_KEY];
            }
            else
            {
                session[SESSION_KEY] = messages;
            }

            messages.Add(new FlashMessage {Type = type, Message = message});
        }

        /// <summary>
        /// Get flash messages in session. This will also flush messages from session.
        /// </summary>
        /// <param name="request">HttpRequestBase</param>
        /// <returns>flash messages</returns>
        public static FlashMessages GetFlashMessages(this HttpRequestBase request)
        {
            var session = request.RequestContext.HttpContext.Session;

            var messages = session[SESSION_KEY];
            session[SESSION_KEY] = new FlashMessages();

            if (messages == null)
            {
                return new FlashMessages();
            }

            return (FlashMessages)messages;
        }
    }

    public class FlashMessages : List<FlashMessage>
    {
    }

    public class FlashMessage
    {
        public string Type { get; set; }
        public string Message { get; set; }
    }
}
