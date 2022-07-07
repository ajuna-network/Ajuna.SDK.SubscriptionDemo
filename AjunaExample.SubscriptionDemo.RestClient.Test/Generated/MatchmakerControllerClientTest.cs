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
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker;
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public class MatchmakerControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker.BracketRange GetTestValue2()
      {
         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker.BracketRange result;
         result = new AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker.BracketRange();
         result.Start = this.GetTestValueU32();
         result.End = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestBrackets()
      {
         // Construct new Mockup client to test with.
         MatchmakerControllerMockupClient mockupClient = new MatchmakerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         MatchmakerControllerClient rpcClient = new MatchmakerControllerClient(_httpClient, subscriptionClient);
         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker.BracketRange mockupValue = this.GetTestValue2();
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeBrackets(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetBrackets(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker.BracketRange rpcResult = await rpcClient.GetBrackets(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 GetTestValue4()
      {
         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 result;
         result = new AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32();
         result.Value = new AjunaExample.SubscriptionDemo.NetApi.Generated.Model.Base.Arr32U8();
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
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> GetTestValue5()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Create(this.GetTestValueU32(), this.GetTestValueU32());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestPlayers()
      {
         // Construct new Mockup client to test with.
         MatchmakerControllerMockupClient mockupClient = new MatchmakerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         MatchmakerControllerClient rpcClient = new MatchmakerControllerClient(_httpClient, subscriptionClient);
         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 mockupValue = this.GetTestValue4();
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> mockupKey = this.GetTestValue5();

         Assert.IsTrue(await rpcClient.SubscribePlayers(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetPlayers(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 rpcResult = await rpcClient.GetPlayers(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 GetTestValue7()
      {
         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 result;
         result = new AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32();
         result.Value = new AjunaExample.SubscriptionDemo.NetApi.Generated.Model.Base.Arr32U8();
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
      public async System.Threading.Tasks.Task TestPlayerQueue()
      {
         // Construct new Mockup client to test with.
         MatchmakerControllerMockupClient mockupClient = new MatchmakerControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         MatchmakerControllerClient rpcClient = new MatchmakerControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U8 mockupValue = this.GetTestValueU8();
         AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 mockupKey = this.GetTestValue7();

         Assert.IsTrue(await rpcClient.SubscribePlayerQueue(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetPlayerQueue(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U8 rpcResult = await rpcClient.GetPlayerQueue(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}