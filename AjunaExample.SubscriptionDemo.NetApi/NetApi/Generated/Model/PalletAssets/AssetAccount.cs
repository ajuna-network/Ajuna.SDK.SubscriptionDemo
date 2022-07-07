//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using Ajuna.NetApi.Model.Types.Primitive;
using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAssets;
using System.Collections.Generic;


namespace AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAssets
{
    
    
    /// <summary>
    /// >> 130 - Composite[pallet_assets.types.AssetAccount]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class AssetAccount : BaseType
    {
        
        /// <summary>
        /// >> balance
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _balance;
        
        /// <summary>
        /// >> is_frozen
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Bool _isFrozen;
        
        /// <summary>
        /// >> reason
        /// </summary>
        private AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAssets.EnumExistenceReason _reason;
        
        /// <summary>
        /// >> extra
        /// </summary>
        private BaseTuple _extra;
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this._balance = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.Bool IsFrozen
        {
            get
            {
                return this._isFrozen;
            }
            set
            {
                this._isFrozen = value;
            }
        }
        
        public AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAssets.EnumExistenceReason Reason
        {
            get
            {
                return this._reason;
            }
            set
            {
                this._reason = value;
            }
        }
        
        public BaseTuple Extra
        {
            get
            {
                return this._extra;
            }
            set
            {
                this._extra = value;
            }
        }
        
        public override string TypeName()
        {
            return "AssetAccount";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Balance.Encode());
            result.AddRange(IsFrozen.Encode());
            result.AddRange(Reason.Encode());
            result.AddRange(Extra.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Balance = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Balance.Decode(byteArray, ref p);
            IsFrozen = new Ajuna.NetApi.Model.Types.Primitive.Bool();
            IsFrozen.Decode(byteArray, ref p);
            Reason = new AjunaExample.SubscriptionDemo.NetApi.Generated.Model.PalletAssets.EnumExistenceReason();
            Reason.Decode(byteArray, ref p);
            Extra = new BaseTuple();
            Extra.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
