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
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTreasury;
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.FrameSupport;
   
   public class TreasuryControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      [Test()]
      public async System.Threading.Tasks.Task TestProposalCount()
      {
         // Construct new Mockup client to test with.
         TreasuryControllerMockupClient mockupClient = new TreasuryControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         TreasuryControllerClient rpcClient = new TreasuryControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeProposalCount());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetProposalCount(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetProposalCount();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTreasury.Proposal GetTestValue3()
      {
         Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTreasury.Proposal result;
         result = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTreasury.Proposal();
         result.Proposer = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32();
         result.Proposer = this.GetTestValue4();
         result.Value = this.GetTestValueU128();
         result.Beneficiary = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32();
         result.Beneficiary = this.GetTestValue5();
         result.Bond = this.GetTestValueU128();
         return result;
      }
      public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 GetTestValue4()
      {
         Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 result;
         result = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32();
         result.Value = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 GetTestValue5()
      {
         Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 result;
         result = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32();
         result.Value = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestProposals()
      {
         // Construct new Mockup client to test with.
         TreasuryControllerMockupClient mockupClient = new TreasuryControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         TreasuryControllerClient rpcClient = new TreasuryControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTreasury.Proposal mockupValue = this.GetTestValue3();
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeProposals(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetProposals(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTreasury.Proposal rpcResult = await rpcClient.GetProposals(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.FrameSupport.BoundedVecT5 GetTestValue7()
      {
         Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.FrameSupport.BoundedVecT5 result;
         result = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.FrameSupport.BoundedVecT5();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U32[] {
                  this.GetTestValueU32()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestApprovals()
      {
         // Construct new Mockup client to test with.
         TreasuryControllerMockupClient mockupClient = new TreasuryControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         TreasuryControllerClient rpcClient = new TreasuryControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.FrameSupport.BoundedVecT5 mockupValue = this.GetTestValue7();


         Assert.IsTrue(await rpcClient.SubscribeApprovals());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetApprovals(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.FrameSupport.BoundedVecT5 rpcResult = await rpcClient.GetApprovals();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}