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
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.FrameSupport;
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpConsensusSlots;
   using AjunaExample.SubscriptionDemo.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class AuraControllerMockupClient : MockupBaseClient, IAuraControllerMockupClient
   {
      private HttpClient _httpClient;
      public AuraControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAuthorities(WeakBoundedVecT1 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Aura/Authorities", value.Encode(), AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAura.AuraStorage.AuthoritiesParams());
      }
      public async Task<bool> SetCurrentSlot(Slot value)
      {
         return await SendMockupRequestAsync(_httpClient, "Aura/CurrentSlot", value.Encode(), AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAura.AuraStorage.CurrentSlotParams());
      }
   }
}