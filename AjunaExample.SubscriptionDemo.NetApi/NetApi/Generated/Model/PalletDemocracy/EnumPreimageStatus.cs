//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;


namespace AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy
{
    
    
    public enum PreimageStatus
    {
        
        Missing,
        
        Available,
    }
    
    /// <summary>
    /// >> 173 - Variant[pallet_democracy.PreimageStatus]
    /// </summary>
    public sealed class EnumPreimageStatus : BaseEnumExt<PreimageStatus, Ajuna.NetApi.Model.Types.Primitive.U32, BaseTuple<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>, AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.NetApi.Model.Types.Primitive.U32, BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>>>
    {
    }
}