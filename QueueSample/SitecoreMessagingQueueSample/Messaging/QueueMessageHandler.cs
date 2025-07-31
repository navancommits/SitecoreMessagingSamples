namespace SitecoreMessagingQueueSample.Messaging
{
    using Newtonsoft.Json.Linq;
    using Sitecore.Framework.Messaging;
    using Sitecore.Framework.Messaging.DeferStrategies;
    using System;
    using System.Threading.Tasks;

    public class QueueMessageHandler : IMessageHandler<JObject>, IMessageHandler
    {
        //private readonly IMessageBus<QueueSampleBus> _bus;
        public QueueMessageHandler()
        {
            //this._bus = bus;
        }

        public async Task Handle(JObject message, IMessageReceiveContext receiveContext, IMessageReplyContext replyContext)
        {
            //Log the incoming message
            Sitecore.Diagnostics.Log.Info($"Message Received: {message.ToString()}", this);

            // Implement your business logic

            await Task.CompletedTask;
        }
    }

    public class CustomSendMessageHandler : IMessageHandler<SampleMessageContract>, IMessageHandler
    {
        //private readonly IMessageBus<QueueSampleBus> _bus;
        public CustomSendMessageHandler()
        {
            //this._bus = bus;
        }

        public async Task Handle(SampleMessageContract message, IMessageReceiveContext receiveContext, IMessageReplyContext replyContext)
        {
            //Log the incoming message
            Sitecore.Diagnostics.Log.Info($"Message Received: {message.Message.ToString()}", this);

            // connect to queue - example
            //var sender = new AzureServiceBusQueueSender("custommessagingqueue", "customqueue");

            //try
            //{
            //    await sender.SendMessageAsync(message.Message.ToString());
            //    Sitecore.Diagnostics.Log.Info("Message sent to Azure Service Bus queue.", this);
            //}
            //catch (Exception ex)
            //{
            //    Sitecore.Diagnostics.Log.Error("Error sending message to Azure Service Bus", ex, this);
            //}

            await Task.CompletedTask;

        }

    }
}
