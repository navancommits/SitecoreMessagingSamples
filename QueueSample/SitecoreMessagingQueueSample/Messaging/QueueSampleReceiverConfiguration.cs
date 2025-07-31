namespace SitecoreMessagingQueueSample.Messaging
{
    using Microsoft.Extensions.DependencyInjection;
    using Newtonsoft.Json.Linq;
    using Sitecore.DependencyInjection;
    using Sitecore.Framework.Messaging;

    public class QueueSampleReceiverConfiguration : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IMessageHandler<JObject>, QueueMessageHandler>();
            serviceCollection.AddTransient<IMessageHandler<SampleMessageContract>, CustomSendMessageHandler>();
        }
    }
}
