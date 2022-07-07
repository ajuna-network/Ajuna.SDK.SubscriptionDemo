//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjunaExample.SubscriptionDemo.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using AjunaExample.SubscriptionDemo.RestClient.Mockup.Generated.Clients;
   using AjunaExample.SubscriptionDemo.RestClient.Generated.Clients;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public class TimestampControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      [Test()]
      public async System.Threading.Tasks.Task TestNow()
      {
         // Construct new Mockup client to test with.
         TimestampControllerMockupClient mockupClient = new TimestampControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         TimestampControllerClient rpcClient = new TimestampControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U64 mockupValue = this.GetTestValueU64();


         Assert.IsTrue(await rpcClient.SubscribeNow());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetNow(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U64 rpcResult = await rpcClient.GetNow();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestDidUpdate()
      {
         // Construct new Mockup client to test with.
         TimestampControllerMockupClient mockupClient = new TimestampControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         TimestampControllerClient rpcClient = new TimestampControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.Bool mockupValue = this.GetTestValueBool();


         Assert.IsTrue(await rpcClient.SubscribeDidUpdate());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetDidUpdate(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.Bool rpcResult = await rpcClient.GetDidUpdate();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
