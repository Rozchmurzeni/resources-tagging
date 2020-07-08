using System;
using System.Threading.Tasks;
using ResourcesTagging.Models;
using ResourcesTagging.Providers;
using ResourcesTagging.Services;

namespace ResourcesTagging.Functions
{
    public class SendEventLambda
    {
        protected async Task InvokeAsync()
        {
            var sqsClient = AwsClientsSingletonsProvider.GetSqsClient();
            var queueService = new QueueService(sqsClient);

            await queueService.AddMessageAsync(new ItemMessage(Guid.NewGuid()), GetQueueUrl());
        }

        private static string GetQueueUrl() => Environment.GetEnvironmentVariable("QueueUrl");
    }
}
