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
   using Ajuna.NetApi.Model.Types.Primitive;
   using AjunaExample.SubscriptionDemo.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class TimestampControllerMockupClient : MockupBaseClient, ITimestampControllerMockupClient
   {
      private HttpClient _httpClient;
      public TimestampControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetNow(U64 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Timestamp/Now", value.Encode(), AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletTimestamp.TimestampStorage.NowParams());
      }
      public async Task<bool> SetDidUpdate(Bool value)
      {
         return await SendMockupRequestAsync(_httpClient, "Timestamp/DidUpdate", value.Encode(), AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletTimestamp.TimestampStorage.DidUpdateParams());
      }
   }
}
