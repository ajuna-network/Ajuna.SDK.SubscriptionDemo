//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.SubscriptionDemo.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore;
   using Ajuna.SDK.SubscriptionDemo.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class SudoControllerMockupClient : MockupBaseClient, ISudoControllerMockupClient
   {
      private HttpClient _httpClient;
      public SudoControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetKey(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Sudo/Key", value.Encode(), Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletSudo.SudoStorage.KeyParams());
      }
   }
}