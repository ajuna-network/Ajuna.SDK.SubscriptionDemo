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
   using Ajuna.NetApi.Model.Types.Primitive;
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletTreasury;
   using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.FrameSupport;
   
   public interface ITreasuryControllerMockupClient
   {
      Task<bool> SetProposalCount(U32 value);
      Task<bool> SetProposals(Proposal value, U32 key);
      Task<bool> SetApprovals(BoundedVecT5 value);
   }
}