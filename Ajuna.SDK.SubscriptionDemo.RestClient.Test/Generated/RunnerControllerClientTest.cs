//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.SubscriptionDemo.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.SDK.SubscriptionDemo.RestClient.Mockup.Generated.Clients;
   using Ajuna.SDK.SubscriptionDemo.RestClient.Generated.Clients;
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.AjunaCommon;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public class RunnerControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.AjunaCommon.EnumRunnerState GetTestValue2()
      {
         Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.AjunaCommon.EnumRunnerState result;
         result = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.AjunaCommon.EnumRunnerState();
         result.Create(this.GetTestValueEnum<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.AjunaCommon.RunnerState>(), this.GetTestValue3());
         return result;
      }
      public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.AjunaCommon.State GetTestValue3()
      {
         Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.AjunaCommon.State result;
         result = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.AjunaCommon.State();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestRunners()
      {
         // Construct new Mockup client to test with.
         RunnerControllerMockupClient mockupClient = new RunnerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         RunnerControllerClient rpcClient = new RunnerControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.AjunaCommon.EnumRunnerState mockupValue = this.GetTestValue2();
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeRunners(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetRunners(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.AjunaCommon.EnumRunnerState rpcResult = await rpcClient.GetRunners(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestNonce()
      {
         // Construct new Mockup client to test with.
         RunnerControllerMockupClient mockupClient = new RunnerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         RunnerControllerClient rpcClient = new RunnerControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeNonce());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetNonce(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetNonce();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
