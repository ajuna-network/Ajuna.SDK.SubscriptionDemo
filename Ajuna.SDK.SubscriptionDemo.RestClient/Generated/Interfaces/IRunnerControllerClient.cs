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
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.AjunaCommon;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IRunnerControllerClient
   {
      Task<EnumRunnerState> GetRunners(U32 key);
      Task<bool> SubscribeRunners(U32 key);
      Task<U32> GetNonce();
      Task<bool> SubscribeNonce();
   }
}