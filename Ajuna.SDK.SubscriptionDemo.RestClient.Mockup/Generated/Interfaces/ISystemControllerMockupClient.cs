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
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.FrameSystem;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.FrameSupport;
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PrimitiveTypes;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpRuntime;
   
   public interface ISystemControllerMockupClient
   {
      Task<bool> SetAccount(AccountInfo value, Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<bool> SetExtrinsicCount(U32 value);
      Task<bool> SetBlockWeight(PerDispatchClassT1 value);
      Task<bool> SetAllExtrinsicsLen(U32 value);
      Task<bool> SetBlockHash(H256 value, U32 key);
      Task<bool> SetExtrinsicData(BaseVec<U8> value, U32 key);
      Task<bool> SetNumber(U32 value);
      Task<bool> SetParentHash(H256 value);
      Task<bool> SetDigest(Digest value);
      Task<bool> SetEvents(BaseVec<EventRecord> value);
      Task<bool> SetEventCount(U32 value);
      Task<bool> SetEventTopics(BaseVec<BaseTuple<U32, U32>> value, H256 key);
      Task<bool> SetLastRuntimeUpgrade(LastRuntimeUpgradeInfo value);
      Task<bool> SetUpgradedToU32RefCount(Bool value);
      Task<bool> SetUpgradedToTripleRefCount(Bool value);
      Task<bool> SetExecutionPhase(EnumPhase value);
   }
}
