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
using Ajuna.ServiceLayer.Attributes;
using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.FrameSupport;
using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletBalances;
using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore;
using AjunaExample.SubscriptionDemo.RestService.Generated.Storage;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AjunaExample.SubscriptionDemo.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// BalancesController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class BalancesController : ControllerBase
    {
        
        private IBalancesStorage _balancesStorage;
        
        /// <summary>
        /// BalancesController constructor.
        /// </summary>
        public BalancesController(IBalancesStorage balancesStorage)
        {
            _balancesStorage = balancesStorage;
        }
        
        /// <summary>
        /// >> TotalIssuance
        ///  The total units issued in the system.
        /// </summary>
        [HttpGet("TotalIssuance")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U128), 200)]
        [StorageKeyBuilder(typeof(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletBalances.BalancesStorage), "TotalIssuanceParams")]
        public IActionResult GetTotalIssuance()
        {
            return this.Ok(_balancesStorage.GetTotalIssuance());
        }
        
        /// <summary>
        /// >> Account
        ///  The Balances pallet example of storing the balance of an account.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///     type AccountStore = StorageMapShim<Self::Account<Runtime>, frame_system::Provider<Runtime>, AccountId, Self::AccountData<Balance>>
        ///   }
        ///  ```
        /// 
        ///  You can also store the balance of an account in the `System` pallet.
        /// 
        ///  # Example
        /// 
        ///  ```nocompile
        ///   impl pallet_balances::Config for Runtime {
        ///    type AccountStore = System
        ///   }
        ///  ```
        /// 
        ///  But this comes with tradeoffs, storing account balances in the system pallet stores
        ///  `frame_system` data alongside the account data contrary to storing account balances in the
        ///  `Balances` pallet, which uses a `StorageMap` to store balances data only.
        ///  NOTE: This is only used in the case that this pallet is used to store balances.
        /// </summary>
        [HttpGet("Account")]
        [ProducesResponseType(typeof(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletBalances.AccountData), 200)]
        [StorageKeyBuilder(typeof(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletBalances.BalancesStorage), "AccountParams", typeof(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32))]
        public IActionResult GetAccount(string key)
        {
            return this.Ok(_balancesStorage.GetAccount(key));
        }
        
        /// <summary>
        /// >> Locks
        ///  Any liquidity locks on some account balances.
        ///  NOTE: Should only be accessed when setting, changing and freeing a lock.
        /// </summary>
        [HttpGet("Locks")]
        [ProducesResponseType(typeof(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.FrameSupport.WeakBoundedVecT3), 200)]
        [StorageKeyBuilder(typeof(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletBalances.BalancesStorage), "LocksParams", typeof(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32))]
        public IActionResult GetLocks(string key)
        {
            return this.Ok(_balancesStorage.GetLocks(key));
        }
        
        /// <summary>
        /// >> Reserves
        ///  Named reserves on some account balances.
        /// </summary>
        [HttpGet("Reserves")]
        [ProducesResponseType(typeof(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.FrameSupport.BoundedVecT1), 200)]
        [StorageKeyBuilder(typeof(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletBalances.BalancesStorage), "ReservesParams", typeof(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32))]
        public IActionResult GetReserves(string key)
        {
            return this.Ok(_balancesStorage.GetReserves(key));
        }
        
        /// <summary>
        /// >> StorageVersion
        ///  Storage version of the pallet.
        /// 
        ///  This is set to v2.0.0 for new networks.
        /// </summary>
        [HttpGet("StorageVersion")]
        [ProducesResponseType(typeof(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletBalances.EnumReleases), 200)]
        [StorageKeyBuilder(typeof(AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletBalances.BalancesStorage), "StorageVersionParams")]
        public IActionResult GetStorageVersion()
        {
            return this.Ok(_balancesStorage.GetStorageVersion());
        }
    }
}
