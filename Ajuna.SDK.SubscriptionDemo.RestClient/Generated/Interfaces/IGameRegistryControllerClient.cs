//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.SubscriptionDemo.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IGameRegistryControllerClient
   {
      Task<BaseVec<U32>> GetQueued();
      Task<bool> SubscribeQueued();
      Task<U32> GetPlayers(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 key);
      Task<bool> SubscribePlayers(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 key);
   }
}