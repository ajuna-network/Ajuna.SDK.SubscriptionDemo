//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjunaExample.SubscriptionDemo.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletGrandpa;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   
   public interface IGrandpaControllerMockupClient
   {
      Task<bool> SetState(EnumStoredState value);
      Task<bool> SetPendingChange(StoredPendingChange value);
      Task<bool> SetNextForced(U32 value);
      Task<bool> SetStalled(BaseTuple<U32, U32> value);
      Task<bool> SetCurrentSetId(U64 value);
      Task<bool> SetSetIdSession(U32 value, U64 key);
   }
}
