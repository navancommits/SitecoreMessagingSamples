namespace SitecoreMessagingQueueSample.Messaging
{
    
    using System;
    using System.Text.Json.Serialization;

    public class SampleMessageContract
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
    }
}
