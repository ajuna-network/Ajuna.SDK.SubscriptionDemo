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
using Ajuna.ServiceLayer.Storage;
using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker;
using Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Ajuna.SDK.SubscriptionDemo.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IMatchmakerStorage interface definition.
    /// </summary>
    public interface IMatchmakerStorage : IStorage
    {
        
        /// <summary>
        /// >> Brackets
        ///  Map of brackets with their index
        /// </summary>
        Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker.BracketRange GetBrackets(string key);
        
        /// <summary>
        /// >> Players
        ///  A double map indexed by bracket and account
        /// </summary>
        Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 GetPlayers(string key);
        
        /// <summary>
        /// >> PlayerQueue
        ///  A map tracking which accounts are queued
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U8 GetPlayerQueue(string key);
    }
    
    /// <summary>
    /// MatchmakerStorage class definition.
    /// </summary>
    public sealed class MatchmakerStorage : IMatchmakerStorage
    {
        
        /// <summary>
        /// _bracketsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker.BracketRange> _bracketsTypedStorage;
        
        /// <summary>
        /// _playersTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32> _playersTypedStorage;
        
        /// <summary>
        /// _playerQueueTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U8> _playerQueueTypedStorage;
        
        /// <summary>
        /// MatchmakerStorage constructor.
        /// </summary>
        public MatchmakerStorage(IStorageDataProvider storageDataProvider, IStorageChangeDelegate storageChangeDelegate)
        {
            this.BracketsTypedStorage = new TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker.BracketRange>("Matchmaker.Brackets", storageDataProvider, storageChangeDelegate);
            this.PlayersTypedStorage = new TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32>("Matchmaker.Players", storageDataProvider, storageChangeDelegate);
            this.PlayerQueueTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U8>("Matchmaker.PlayerQueue", storageDataProvider, storageChangeDelegate);
        }
        
        /// <summary>
        /// _bracketsTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker.BracketRange> BracketsTypedStorage
        {
            get
            {
                return _bracketsTypedStorage;
            }
            set
            {
                _bracketsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _playersTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32> PlayersTypedStorage
        {
            get
            {
                return _playersTypedStorage;
            }
            set
            {
                _playersTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _playerQueueTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U8> PlayerQueueTypedStorage
        {
            get
            {
                return _playerQueueTypedStorage;
            }
            set
            {
                _playerQueueTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await BracketsTypedStorage.InitializeAsync("Matchmaker", "Brackets");
            await PlayersTypedStorage.InitializeAsync("Matchmaker", "Players");
            await PlayerQueueTypedStorage.InitializeAsync("Matchmaker", "PlayerQueue");
        }
        
        /// <summary>
        /// Implements any storage change for Matchmaker.Brackets
        /// </summary>
        [StorageChange("Matchmaker", "Brackets")]
        public void OnUpdateBrackets(string key, string data)
        {
            BracketsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Brackets
        ///  Map of brackets with their index
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker.BracketRange GetBrackets(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (BracketsTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletAjunaMatchmaker.BracketRange result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Matchmaker.Players
        /// </summary>
        [StorageChange("Matchmaker", "Players")]
        public void OnUpdatePlayers(string key, string data)
        {
            PlayersTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Players
        ///  A double map indexed by bracket and account
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 GetPlayers(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (PlayersTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.SpCore.AccountId32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Matchmaker.PlayerQueue
        /// </summary>
        [StorageChange("Matchmaker", "PlayerQueue")]
        public void OnUpdatePlayerQueue(string key, string data)
        {
            PlayerQueueTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> PlayerQueue
        ///  A map tracking which accounts are queued
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U8 GetPlayerQueue(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (PlayerQueueTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U8 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
