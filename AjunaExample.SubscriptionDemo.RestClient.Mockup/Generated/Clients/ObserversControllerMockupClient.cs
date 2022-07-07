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
   using Ajuna.NetApi.Model.Types.Base;
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore;
   using AjunaExample.SubscriptionDemo.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class ObserversControllerMockupClient : MockupBaseClient, IObserversControllerMockupClient
   {
      private HttpClient _httpClient;
      public ObserversControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetMembers(BaseVec<AccountId32> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Observers/Members", value.Encode(), AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletObservers.ObserversStorage.MembersParams());
      }
      public async Task<bool> SetPrime(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Observers/Prime", value.Encode(), AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletObservers.ObserversStorage.PrimeParams());
      }
   }
}
