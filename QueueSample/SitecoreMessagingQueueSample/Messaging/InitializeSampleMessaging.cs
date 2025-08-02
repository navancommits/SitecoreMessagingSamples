namespace SitecoreMessagingQueueSample.Messaging
{
    using Sitecore.Framework.Messaging;
    using Sitecore.Pipelines;
    using System;

    public class InitializeSampleMessaging
    {
        private readonly IServiceProvider serviceProvider;
        public InitializeSampleMessaging(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public void Process(PipelineArgs args)
        {
            this.serviceProvider.StartMessageBus<CustomQueueSampleBus>();
        }
    }
}
