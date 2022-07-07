//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjunaExample.SubscriptionDemo.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker;
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore;
   using Ajuna.NetApi.Model.Types.Primitive;
   using AjunaExample.SubscriptionDemo.RestClient.Generated.Interfaces;
   
   public sealed class MatchmakerControllerClient : BaseClient, IMatchmakerControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public MatchmakerControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BracketRange> GetBrackets(U32 key)
      {
         return await SendRequestAsync<BracketRange>(_httpClient, "matchmaker/brackets", AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletMatchmaker.MatchmakerStorage.BracketsParams(key));
      }
      public async Task<bool> SubscribeBrackets(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Matchmaker.Brackets", AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletMatchmaker.MatchmakerStorage.BracketsParams(key));
      }
      public async Task<AccountId32> GetPlayers(Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, U32> key)
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "matchmaker/players", AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletMatchmaker.MatchmakerStorage.PlayersParams(key));
      }
      public async Task<bool> SubscribePlayers(Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, U32> key)
      {
         return await _subscriptionClient.SubscribeAsync("Matchmaker.Players", AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletMatchmaker.MatchmakerStorage.PlayersParams(key));
      }
      public async Task<U8> GetPlayerQueue(AccountId32 key)
      {
         return await SendRequestAsync<U8>(_httpClient, "matchmaker/playerqueue", AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletMatchmaker.MatchmakerStorage.PlayerQueueParams(key));
      }
      public async Task<bool> SubscribePlayerQueue(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Matchmaker.PlayerQueue", AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletMatchmaker.MatchmakerStorage.PlayerQueueParams(key));
      }
   }
}