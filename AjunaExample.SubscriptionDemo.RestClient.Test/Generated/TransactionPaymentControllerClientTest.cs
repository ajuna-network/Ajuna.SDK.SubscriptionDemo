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
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpArithmetic;
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletTransactionPayment;
   
   public class TransactionPaymentControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpArithmetic.FixedU128 GetTestValue2()
      {
         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpArithmetic.FixedU128 result;
         result = new AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpArithmetic.FixedU128();
         result.Value = this.GetTestValueU128();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestNextFeeMultiplier()
      {
         // Construct new Mockup client to test with.
         TransactionPaymentControllerMockupClient mockupClient = new TransactionPaymentControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         TransactionPaymentControllerClient rpcClient = new TransactionPaymentControllerClient(_httpClient, subscriptionClient);
         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpArithmetic.FixedU128 mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeNextFeeMultiplier());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetNextFeeMultiplier(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpArithmetic.FixedU128 rpcResult = await rpcClient.GetNextFeeMultiplier();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletTransactionPayment.EnumReleases GetTestValue4()
      {
         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletTransactionPayment.EnumReleases result;
         result = new AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletTransactionPayment.EnumReleases();
         result.Create(this.GetTestValueEnum<AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletTransactionPayment.Releases>());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestStorageVersion()
      {
         // Construct new Mockup client to test with.
         TransactionPaymentControllerMockupClient mockupClient = new TransactionPaymentControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         TransactionPaymentControllerClient rpcClient = new TransactionPaymentControllerClient(_httpClient, subscriptionClient);
         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletTransactionPayment.EnumReleases mockupValue = this.GetTestValue4();


         Assert.IsTrue(await rpcClient.SubscribeStorageVersion());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetStorageVersion(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletTransactionPayment.EnumReleases rpcResult = await rpcClient.GetStorageVersion();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
