using System.Net.WebSockets;
using Ajuna.ServiceLayer.Model;
using Ajuna.SDK.SubscriptionDemo.RestClient;
using Ajuna.SDK.SubscriptionDemo.RestClient.Generated.Clients;

namespace Ajuna.SDK.SubscriptionDemo.Console
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // Create BaseSubscriptionClient and connect
            var subscriptionClient = new BaseSubscriptionClient(new ClientWebSocket());
            subscriptionClient.ConnectAsync(new Uri($"{GetBaseAddress().Replace("http", "ws")}/ws"), CancellationToken.None)
                .Wait();
             
            // Assign Generic Handler for Storage Change
            subscriptionClient.OnStorageChange = HandleChange;

            // Create HttpClient
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri(GetBaseAddress())
            };
            
            // Create SystemControllerClient
            var systemControllerClient = new SystemControllerClient(httpClient, subscriptionClient);

            // Subscribe to Number Changes
            var subscribeNumberTask = systemControllerClient.SubscribeNumber();
            subscribeNumberTask.Wait();
            var subscribedSuccessfully = subscribeNumberTask.Result;
            
            // Continue only if Subscription has succeeded
            if (subscribedSuccessfully)
            {
                System.Console.WriteLine("Successfully Subscribed. Now listening for Storage Changes...");
                System.Console.WriteLine("Press ESC to exit");
            }
            else
            {
                System.Console.WriteLine("Subscription failed. Exiting...");
                return;
            }

            // Keep reading the stream waiting for Storage Changes and exit when the user presses the ESCAPE key
            bool listenForStorageChanges = true;
            while (listenForStorageChanges)
            {
                var receiveTask =  subscriptionClient.ReceiveNextAsync(CancellationToken.None);
                receiveTask.Wait();
                
                if (System.Console.KeyAvailable && System.Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    listenForStorageChanges = false;
                }
            }
         
            // Close Connection 
            subscriptionClient.CloseAsync(WebSocketCloseStatus.Empty,"",CancellationToken.None).Wait();
        }
        
        private static string GetBaseAddress()
        {
            return Environment.GetEnvironmentVariable("AJUNA_SERVICE_ENDPOINT") ?? "http://localhost:61752";
        }

        private static void HandleChange(StorageChangeMessage message)
        {
            System.Console.WriteLine("New Change: " + message.Data);
        }
    }
}