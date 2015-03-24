using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Configuration;

using Amazon;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Amazon.SimpleNotificationService.Util;
using Amazon.SQS;
using Amazon.SQS.Internal;
using Amazon.SQS.Model;
using Amazon.SQS.Util;

namespace SQS
{
    public class Program
    {
        static System.Timers.Timer myTimer;

        static void Main(string[] args)
        {
            var p = new Program();
            //p.ReceiveAndDeleteFromSQS();
            
            p.GetQueueAttributesSQS();

            //myTimer = new System.Timers.Timer();
            //myTimer.Interval = 10;
            //myTimer.Elapsed += new ElapsedEventHandler(deleteQueue);
            //myTimer.AutoReset = true;
            //myTimer.Start();

            Console.Read();
        }

        // using timer to loop through the SQS queue and delete all messages
        static void deleteQueue(object source, ElapsedEventArgs e)
        {
            myTimer.Stop();

            var queueUrl = ConfigurationManager.AppSettings["QueueUrl"];
            var client = new AmazonSQSClient(RegionEndpoint.APSoutheast1);
            var msgs = client.ReceiveMessage(new ReceiveMessageRequest() { QueueUrl = queueUrl, MaxNumberOfMessages = 10 });

            var messagesToDelete = new List<Amazon.SQS.Model.Message>();

            foreach (var m in msgs.Messages)
            {
                messagesToDelete.Add(m);
            }

            if (messagesToDelete.Count > 0)
            {
                Console.WriteLine("Deleting 10 messages.");
                var messagesToDeleteRequests = messagesToDelete.Select(x => new DeleteMessageBatchRequestEntry() { Id = x.MessageId, ReceiptHandle = x.ReceiptHandle }).ToList();

                client.DeleteMessageBatch(new DeleteMessageBatchRequest() { QueueUrl = queueUrl, Entries = messagesToDeleteRequests });
            }
            else
            {
                Console.WriteLine("Nothing in the Queue");
            }

            myTimer.Start();
        }

        public void GetQueueAttributesSQS()
        {
            // refer to http://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_GetQueueAttributes.html
            // for list of QueueAttributes

            var queueUrl = ConfigurationManager.AppSettings["QueueUrl"];
            var client = new AmazonSQSClient(RegionEndpoint.APSoutheast1);

            var test = client.GetQueueAttributes(queueUrl, new List<string>() { "ApproximateNumberOfMessages", "VisibilityTimeout" });
        }

        // receive messages from SQS and delete those messages
        public void ReceiveAndDeleteFromSQS()
        {
            var queueUrl = ConfigurationManager.AppSettings["QueueUrl"];
            var client = new AmazonSQSClient(RegionEndpoint.APSoutheast1);
            var msgs = client.ReceiveMessage(new ReceiveMessageRequest() { QueueUrl = queueUrl, MaxNumberOfMessages = 100 });

            var messagesToDelete = new List<Amazon.SQS.Model.Message>();

            foreach (var m in msgs.Messages)
            {
                Console.WriteLine(m.Body);
                messagesToDelete.Add(m);
            }

            var messagesToDeleteRequests = messagesToDelete.Select(x => new DeleteMessageBatchRequestEntry() { Id = x.MessageId, ReceiptHandle = x.ReceiptHandle }).ToList();

            client.DeleteMessageBatch(new DeleteMessageBatchRequest() { QueueUrl = queueUrl, Entries = messagesToDeleteRequests });
        }
    }
}
