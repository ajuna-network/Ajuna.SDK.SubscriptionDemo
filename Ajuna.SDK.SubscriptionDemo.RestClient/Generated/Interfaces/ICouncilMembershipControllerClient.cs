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
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore;
   
   public interface ICouncilMembershipControllerClient
   {
      Task<BaseVec<AccountId32>> GetMembers();
      Task<bool> SubscribeMembers();
      Task<AccountId32> GetPrime();
      Task<bool> SubscribePrime();
   }
}