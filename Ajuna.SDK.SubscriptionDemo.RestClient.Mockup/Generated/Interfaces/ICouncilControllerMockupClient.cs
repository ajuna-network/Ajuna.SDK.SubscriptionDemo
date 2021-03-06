//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.SubscriptionDemo.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.FrameSupport;
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.AjunaSoloRuntime;
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletCollective;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore;
   
   public interface ICouncilControllerMockupClient
   {
      Task<bool> SetProposals(BoundedVecT4 value);
      Task<bool> SetProposalOf(EnumCall value, Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<bool> SetVoting(Votes value, Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes.H256 key);
      Task<bool> SetProposalCount(U32 value);
      Task<bool> SetMembers(BaseVec<AccountId32> value);
      Task<bool> SetPrime(AccountId32 value);
   }
}
