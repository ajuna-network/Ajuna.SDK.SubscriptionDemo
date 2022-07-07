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
using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.Base;
using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.IasVerify;
using AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;


namespace AjunaExample.SubscriptionDemo.NetApi.Generated.Model.TeerexPrimitives
{
    
    
    /// <summary>
    /// >> 200 - Composite[teerex_primitives.Enclave]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Enclave : BaseType
    {
        
        /// <summary>
        /// >> pubkey
        /// </summary>
        private AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 _pubkey;
        
        /// <summary>
        /// >> mr_enclave
        /// </summary>
        private AjunaExample.SubscriptionDemo.NetApi.Generated.Model.Base.Arr32U8 _mrEnclave;
        
        /// <summary>
        /// >> timestamp
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U64 _timestamp;
        
        /// <summary>
        /// >> url
        /// </summary>
        private BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> _url;
        
        /// <summary>
        /// >> sgx_mode
        /// </summary>
        private AjunaExample.SubscriptionDemo.NetApi.Generated.Model.IasVerify.EnumSgxBuildMode _sgxMode;
        
        public AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 Pubkey
        {
            get
            {
                return this._pubkey;
            }
            set
            {
                this._pubkey = value;
            }
        }
        
        public AjunaExample.SubscriptionDemo.NetApi.Generated.Model.Base.Arr32U8 MrEnclave
        {
            get
            {
                return this._mrEnclave;
            }
            set
            {
                this._mrEnclave = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U64 Timestamp
        {
            get
            {
                return this._timestamp;
            }
            set
            {
                this._timestamp = value;
            }
        }
        
        public BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> Url
        {
            get
            {
                return this._url;
            }
            set
            {
                this._url = value;
            }
        }
        
        public AjunaExample.SubscriptionDemo.NetApi.Generated.Model.IasVerify.EnumSgxBuildMode SgxMode
        {
            get
            {
                return this._sgxMode;
            }
            set
            {
                this._sgxMode = value;
            }
        }
        
        public override string TypeName()
        {
            return "Enclave";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Pubkey.Encode());
            result.AddRange(MrEnclave.Encode());
            result.AddRange(Timestamp.Encode());
            result.AddRange(Url.Encode());
            result.AddRange(SgxMode.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Pubkey = new AjunaExample.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32();
            Pubkey.Decode(byteArray, ref p);
            MrEnclave = new AjunaExample.SubscriptionDemo.NetApi.Generated.Model.Base.Arr32U8();
            MrEnclave.Decode(byteArray, ref p);
            Timestamp = new Ajuna.NetApi.Model.Types.Primitive.U64();
            Timestamp.Decode(byteArray, ref p);
            Url = new BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
            Url.Decode(byteArray, ref p);
            SgxMode = new AjunaExample.SubscriptionDemo.NetApi.Generated.Model.IasVerify.EnumSgxBuildMode();
            SgxMode.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
