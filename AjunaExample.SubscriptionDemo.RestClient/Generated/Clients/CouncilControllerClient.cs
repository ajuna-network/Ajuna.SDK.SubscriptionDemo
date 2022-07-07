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
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.FrameSupport;
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.AjunaSoloRuntime;
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletCollective;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore;
   using AjunaExample.SubscriptionDemo.RestClient.Generated.Interfaces;
   
   public sealed class CouncilControllerClient : BaseClient, ICouncilControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public CouncilControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT4> GetProposals()
      {
         return await SendRequestAsync<BoundedVecT4>(_httpClient, "council/proposals");
      }
      public async Task<bool> SubscribeProposals()
      {
         return await _subscriptionClient.SubscribeAsync("Council.Proposals");
      }
      public async Task<EnumCall> GetProposalOf(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256 key)
      {
         return await SendRequestAsync<EnumCall>(_httpClient, "council/proposalof", AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletCouncil.CouncilStorage.ProposalOfParams(key));
      }
      public async Task<bool> SubscribeProposalOf(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Council.ProposalOf", AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletCouncil.CouncilStorage.ProposalOfParams(key));
      }
      public async Task<Votes> GetVoting(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256 key)
      {
         return await SendRequestAsync<Votes>(_httpClient, "council/voting", AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletCouncil.CouncilStorage.VotingParams(key));
      }
      public async Task<bool> SubscribeVoting(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Council.Voting", AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletCouncil.CouncilStorage.VotingParams(key));
      }
      public async Task<U32> GetProposalCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "council/proposalcount");
      }
      public async Task<bool> SubscribeProposalCount()
      {
         return await _subscriptionClient.SubscribeAsync("Council.ProposalCount");
      }
      public async Task<BaseVec<AccountId32>> GetMembers()
      {
         return await SendRequestAsync<BaseVec<AccountId32>>(_httpClient, "council/members");
      }
      public async Task<bool> SubscribeMembers()
      {
         return await _subscriptionClient.SubscribeAsync("Council.Members");
      }
      public async Task<AccountId32> GetPrime()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "council/prime");
      }
      public async Task<bool> SubscribePrime()
      {
         return await _subscriptionClient.SubscribeAsync("Council.Prime");
      }
   }
}
