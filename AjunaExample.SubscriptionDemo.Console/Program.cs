using System;
using System.Net.Http;
using System.Net.WebSockets;
using System.Threading;
using Ajuna.ServiceLayer.Model;
using AjunaExample.SubscriptionDemo.RestClient;
using AjunaExample.SubscriptionDemo.RestClient.Generated.Clients;

// using AjunaExample.SubscriptionDemo.RestClient;
// using AjunaExample.SubscriptionDemo.RestClient.Generated.Clients;
// using AjunaExample.ServiceLayer.Model;

namespace AjunaExample.SubscriptionDemo.Console
{
    internal class Program
    {
        private static string GetBaseAddress()
        {
            return Environment.GetEnvironmentVariable("AJUNA_SERVICE_ENDPOINT") ?? "http://localhost:61752";
        }

        private static void OnStorageChange(StorageChangeMessage message)
        {
            System.Console.WriteLine("New Change: " + message.Data);
        }
        
        public static void Main(string[] args)
        {
            var subscriptionClient = new BaseSubscriptionClient(new ClientWebSocket());
            subscriptionClient.ConnectAsync(new Uri("ws://127.0.0.1:61752/ws"), CancellationToken.None)
                .Wait();
             
            subscriptionClient.OnStorageChange = OnStorageChange;
            

            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:61752");
            var systemControllerClient = new SystemControllerClient(httpClient, subscriptionClient);

            var subscribeNumberTask = systemControllerClient.SubscribeNumber();

            subscribeNumberTask.Wait();
            var subscribedSuccessfully = subscribeNumberTask.Result;

            while (true)
            {
                var receiveTask =  subscriptionClient.ReceiveNextAsync(CancellationToken.None);
            
                receiveTask.Wait();
            }
          
             
            System.Console.ReadLine();
             
            subscriptionClient.CloseAsync(WebSocketCloseStatus.Empty,"",CancellationToken.None).Wait();
        }
    }
}