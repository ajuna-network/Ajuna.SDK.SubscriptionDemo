//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletObservers
{
    
    
    public sealed class ObserversStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public ObserversStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Observers", "Members"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Observers", "Prime"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32)));
        }
        
        /// <summary>
        /// >> MembersParams
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        public static string MembersParams()
        {
            return RequestGenerator.GetStorage("Observers", "Members", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Members
        ///  The current membership, stored as an ordered Vec.
        /// </summary>
        public async Task<BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>> Members(CancellationToken token)
        {
            string parameters = ObserversStorage.MembersParams();
            return await _client.GetStorageAsync<BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>>(parameters, token);
        }
        
        /// <summary>
        /// >> PrimeParams
        ///  The current prime member, if one exists.
        /// </summary>
        public static string PrimeParams()
        {
            return RequestGenerator.GetStorage("Observers", "Prime", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Prime
        ///  The current prime member, if one exists.
        /// </summary>
        public async Task<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32> Prime(CancellationToken token)
        {
            string parameters = ObserversStorage.PrimeParams();
            return await _client.GetStorageAsync<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>(parameters, token);
        }
    }
    
    public sealed class ObserversCalls
    {
        
        /// <summary>
        /// >> add_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method AddMember(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(18, "Observers", 0, "add_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveMember(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(18, "Observers", 1, "remove_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> swap_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SwapMember(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 remove, Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 add)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(remove.Encode());
            byteArray.AddRange(add.Encode());
            return new Method(18, "Observers", 2, "swap_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> reset_members
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ResetMembers(BaseVec<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32> members)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(members.Encode());
            return new Method(18, "Observers", 3, "reset_members", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> change_key
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ChangeKey(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(18, "Observers", 4, "change_key", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_prime
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetPrime(Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(18, "Observers", 5, "set_prime", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> clear_prime
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ClearPrime()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(18, "Observers", 6, "clear_prime", byteArray.ToArray());
        }
    }
    
    public enum ObserversErrors
    {
        
        /// <summary>
        /// >> AlreadyMember
        /// Already a member.
        /// </summary>
        AlreadyMember,
        
        /// <summary>
        /// >> NotMember
        /// Not a member.
        /// </summary>
        NotMember,
    }
}
