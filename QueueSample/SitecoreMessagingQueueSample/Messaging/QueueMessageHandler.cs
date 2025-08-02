namespace SitecoreMessagingQueueSample.Messaging
{
    using Newtonsoft.Json.Linq;
    using Sitecore.Framework.Messaging;
    using Sitecore.Framework.Messaging.DeferStrategies;
    using System;
    using System.Threading.Tasks;

    public class CustomSendMessageHandler : IMessageHandler<JObject>, IMessageHandler
    {
        public CustomSendMessageHandler()
        {
        }

        public async Task Handle(JObject message, IMessageReceiveContext receiveContext, IMessageReplyContext replyContext)
        {
            //Log the incoming message
            Sitecore.Diagnostics.Log.Info($"Message Received: {message.ToString()}", this);

            // Implement your business logic

            await Task.CompletedTask;
        }
    }

    public class QueueMessageHandler : IMessageHandler<SampleMessageContract>, IMessageHandler
    {
        public QueueMessageHandler()
        {
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
