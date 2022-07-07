//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Ajuna.SDK.SubscriptionDemo.NetApi.Generated
{
    
    
    public sealed class SubstrateClientExt : Ajuna.NetApi.SubstrateClient
    {
        
        /// <summary>
        /// StorageKeyDict for key definition informations.
        /// </summary>
        public System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>> StorageKeyDict;
        
        /// <summary>
        /// SystemStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.FrameSystem.SystemStorage SystemStorage;
        
        /// <summary>
        /// TimestampStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTimestamp.TimestampStorage TimestampStorage;
        
        /// <summary>
        /// AuraStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletAura.AuraStorage AuraStorage;
        
        /// <summary>
        /// GrandpaStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletGrandpa.GrandpaStorage GrandpaStorage;
        
        /// <summary>
        /// BalancesStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletBalances.BalancesStorage BalancesStorage;
        
        /// <summary>
        /// TransactionPaymentStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTransactionPayment.TransactionPaymentStorage TransactionPaymentStorage;
        
        /// <summary>
        /// AssetsStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletAssets.AssetsStorage AssetsStorage;
        
        /// <summary>
        /// VestingStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletVesting.VestingStorage VestingStorage;
        
        /// <summary>
        /// CouncilStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletCouncil.CouncilStorage CouncilStorage;
        
        /// <summary>
        /// CouncilMembershipStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletCouncilMembership.CouncilMembershipStorage CouncilMembershipStorage;
        
        /// <summary>
        /// TreasuryStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTreasury.TreasuryStorage TreasuryStorage;
        
        /// <summary>
        /// DemocracyStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage DemocracyStorage;
        
        /// <summary>
        /// SudoStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletSudo.SudoStorage SudoStorage;
        
        /// <summary>
        /// SchedulerStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletScheduler.SchedulerStorage SchedulerStorage;
        
        /// <summary>
        /// MatchmakerStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletMatchmaker.MatchmakerStorage MatchmakerStorage;
        
        /// <summary>
        /// RunnerStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletRunner.RunnerStorage RunnerStorage;
        
        /// <summary>
        /// GameRegistryStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletGameRegistry.GameRegistryStorage GameRegistryStorage;
        
        /// <summary>
        /// ObserversStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletObservers.ObserversStorage ObserversStorage;
        
        /// <summary>
        /// TeerexStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTeerex.TeerexStorage TeerexStorage;
        
        /// <summary>
        /// SidechainStorage storage calls.
        /// </summary>
        public Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletSidechain.SidechainStorage SidechainStorage;
        
        public SubstrateClientExt(System.Uri uri) : 
                base(uri)
        {
            StorageKeyDict = new System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>>();
            this.SystemStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.FrameSystem.SystemStorage(this);
            this.TimestampStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTimestamp.TimestampStorage(this);
            this.AuraStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletAura.AuraStorage(this);
            this.GrandpaStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletGrandpa.GrandpaStorage(this);
            this.BalancesStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletBalances.BalancesStorage(this);
            this.TransactionPaymentStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTransactionPayment.TransactionPaymentStorage(this);
            this.AssetsStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletAssets.AssetsStorage(this);
            this.VestingStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletVesting.VestingStorage(this);
            this.CouncilStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletCouncil.CouncilStorage(this);
            this.CouncilMembershipStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletCouncilMembership.CouncilMembershipStorage(this);
            this.TreasuryStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTreasury.TreasuryStorage(this);
            this.DemocracyStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletDemocracy.DemocracyStorage(this);
            this.SudoStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletSudo.SudoStorage(this);
            this.SchedulerStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletScheduler.SchedulerStorage(this);
            this.MatchmakerStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletMatchmaker.MatchmakerStorage(this);
            this.RunnerStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletRunner.RunnerStorage(this);
            this.GameRegistryStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletGameRegistry.GameRegistryStorage(this);
            this.ObserversStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletObservers.ObserversStorage(this);
            this.TeerexStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletTeerex.TeerexStorage(this);
            this.SidechainStorage = new Ajuna.SDK.SubscriptionDemo.NetApi.Generated.Model.PalletSidechain.SidechainStorage(this);
        }
    }
}