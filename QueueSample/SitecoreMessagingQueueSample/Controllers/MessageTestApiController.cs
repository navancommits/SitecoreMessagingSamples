namespace SitecoreMessagingQueueSample.Controllers
{
    using Sitecore.Framework.Messaging;
    using Sitecore.Services.Infrastructure.Web.Http;
    using SitecoreMessagingQueueSample.Messaging;
    using System;
    using System.Web.Http;
    using System.Web.Http.Cors;

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MessageTestApiController : ServicesApiController
    {
        private readonly IMessageBus<CustomQueueSampleBus> busQueue;

        public MessageTestApiController(IMessageBus<CustomQueueSampleBus> busQueue)
        {
            this.busQueue = busQueue;
        }

        [HttpGet]
        public string Send()
        {
            busQueue.Send(new SampleMessageContract
            {
                Message = "Hello2",
                Date = DateTime.Now
            });

            return "Sent";
        }
    }
}
