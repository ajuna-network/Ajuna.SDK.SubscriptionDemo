//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjunaExample.SubscriptionDemo.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletGrandpa;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.NetApi.Model.Types.Base;
   using AjunaExample.SubscriptionDemo.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class GrandpaControllerMockupClient : MockupBaseClient, IGrandpaControllerMockupClient
   {
      private HttpClient _httpClient;
      public GrandpaControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetState(EnumStoredState value)
      {
         return await SendMockupRequestAsync(_httpClient, "Grandpa/State", value.Encode(), GrandpaStorage.StateParams());
      }
      public async Task<bool> SetPendingChange(StoredPendingChange value)
      {
         return await SendMockupRequestAsync(_httpClient, "Grandpa/PendingChange", value.Encode(), GrandpaStorage.PendingChangeParams());
      }
      public async Task<bool> SetNextForced(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Grandpa/NextForced", value.Encode(), GrandpaStorage.NextForcedParams());
      }
      public async Task<bool> SetStalled(BaseTuple<U32, U32> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Grandpa/Stalled", value.Encode(), GrandpaStorage.StalledParams());
      }
      public async Task<bool> SetCurrentSetId(U64 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Grandpa/CurrentSetId", value.Encode(), GrandpaStorage.CurrentSetIdParams());
      }
      public async Task<bool> SetSetIdSession(U32 value, U64 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Grandpa/SetIdSession", value.Encode(), GrandpaStorage.SetIdSessionParams(key));
      }
   }
}
