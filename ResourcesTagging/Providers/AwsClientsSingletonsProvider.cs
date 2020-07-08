using System;
using Amazon.SQS;

namespace ResourcesTagging.Providers
{
    public static class AwsClientsSingletonsProvider
    {
        public static IAmazonSQS GetSqsClient() => SqsClientLazy.Value;

        private static readonly Lazy<IAmazonSQS> SqsClientLazy = new Lazy<IAmazonSQS>(() => new AmazonSQSClient());
    }
}
