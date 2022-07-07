//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace AjunaExample.SubscriptionDemo.NetApi.Generated.Model.OrmlVesting
{
    
    
    public enum Error
    {
        
        ZeroVestingPeriod,
        
        ZeroVestingPeriodCount,
        
        InsufficientBalanceToLock,
        
        TooManyVestingSchedules,
        
        AmountLow,
        
        MaxVestingSchedulesExceeded,
    }
    
    /// <summary>
    /// >> 142 - Variant[orml_vesting.module.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/v3/runtime/events-and-errors)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
