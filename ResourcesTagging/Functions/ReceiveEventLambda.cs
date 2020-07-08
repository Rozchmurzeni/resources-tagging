using System.Linq;
using System.Text.Json;
using Amazon.Lambda.SQSEvents;
using ResourcesTagging.Models;

namespace ResourcesTagging.Functions
{
    public class ReceiveEventLambda
    {
        protected void InvokeAsync(SQSEvent sqsEvent)
        {
            var itemMessage = ExtractItemMessage(sqsEvent);
        }

        private static ItemMessage ExtractItemMessage(SQSEvent sqsEvent)
        {
            var sqsMessage = sqsEvent.Records.Single();

            return JsonSerializer.Deserialize<ItemMessage>(sqsMessage.Body);
        }
    }
}
