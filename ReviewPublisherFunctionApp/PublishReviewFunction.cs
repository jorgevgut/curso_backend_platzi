using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ReviewPublisherFunctionApp
{
    public static class PublishReviewFunction
    {
        [FunctionName("PublishReviewFunction")]
        public static void Run([ServiceBusTrigger("CameraReviewPublisher", "CameraReviewBackend", Connection = "")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
