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
using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpFinalityGrandpa;
using System.Collections.Generic;


namespace Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.FrameSupport
{
    
    
    /// <summary>
    /// >> 95 - Composite[frame_support.storage.weak_bounded_vec.WeakBoundedVecT2]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class WeakBoundedVecT2 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private BaseVec<BaseTuple<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpFinalityGrandpa.Public,Ajuna.NetApi.Model.Types.Primitive.U64>> _value;
        
        public BaseVec<BaseTuple<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpFinalityGrandpa.Public,Ajuna.NetApi.Model.Types.Primitive.U64>> Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "WeakBoundedVecT2";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new BaseVec<BaseTuple<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpFinalityGrandpa.Public,Ajuna.NetApi.Model.Types.Primitive.U64>>();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
