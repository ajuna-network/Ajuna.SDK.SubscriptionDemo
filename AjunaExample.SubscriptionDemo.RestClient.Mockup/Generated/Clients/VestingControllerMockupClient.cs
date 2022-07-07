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
   using AjunaExample.SubscriptionDemo.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class VestingControllerMockupClient : MockupBaseClient, IVestingControllerMockupClient
   {
      private HttpClient _httpClient;
      public VestingControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetVestingSchedules(BoundedVecT3 value, AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Vesting/VestingSchedules", value.Encode(), AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletVesting.VestingStorage.VestingSchedulesParams(key));
      }
   }
}