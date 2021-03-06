//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.ServiceLayer.Attributes;
using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore;
using Ajuna.SDK.SubscriptionDemo.RestService.Generated.Storage;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Ajuna.SDK.SubscriptionDemo.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// SudoController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class SudoController : ControllerBase
    {
        
        private ISudoStorage _sudoStorage;
        
        /// <summary>
        /// SudoController constructor.
        /// </summary>
        public SudoController(ISudoStorage sudoStorage)
        {
            _sudoStorage = sudoStorage;
        }
        
        /// <summary>
        /// >> Key
        ///  The `AccountId` of the sudo key.
        /// </summary>
        [HttpGet("Key")]
        [ProducesResponseType(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletSudo.SudoStorage), "KeyParams")]
        public IActionResult GetKey()
        {
            return this.Ok(_sudoStorage.GetKey());
        }
    }
}
