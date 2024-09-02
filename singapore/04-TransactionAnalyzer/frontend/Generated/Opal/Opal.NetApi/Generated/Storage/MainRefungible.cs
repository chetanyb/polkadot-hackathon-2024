//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Opal.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> RefungibleStorage
    /// </summary>
    public sealed class RefungibleStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> RefungibleStorage Constructor
        /// </summary>
        public RefungibleStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Refungible", "TokensMinted"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Opal.NetApi.Generated.Model.up_data_structs.CollectionId), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Refungible", "TokensBurnt"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Opal.NetApi.Generated.Model.up_data_structs.CollectionId), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Refungible", "TokenProperties"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.up_data_structs.TokenId>), typeof(Opal.NetApi.Generated.Model.up_data_structs.PropertiesT2)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Refungible", "TotalSupply"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.up_data_structs.TokenId>), typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Refungible", "Owned"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Opal.NetApi.Generated.Model.up_data_structs.TokenId>), typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Refungible", "AccountBalance"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Refungible", "Balance"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.up_data_structs.TokenId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>), typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Refungible", "Allowance"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.up_data_structs.TokenId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>), typeof(Substrate.NetApi.Model.Types.Primitive.U128)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Refungible", "CollectionAllowance"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>), typeof(Substrate.NetApi.Model.Types.Primitive.Bool)));
        }
        
        /// <summary>
        /// >> TokensMintedParams
        ///  Total amount of minted tokens in a collection.
        /// </summary>
        public static string TokensMintedParams(Opal.NetApi.Generated.Model.up_data_structs.CollectionId key)
        {
            return RequestGenerator.GetStorage("Refungible", "TokensMinted", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> TokensMintedDefault
        /// Default value as hex string
        /// </summary>
        public static string TokensMintedDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> TokensMinted
        ///  Total amount of minted tokens in a collection.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> TokensMinted(Opal.NetApi.Generated.Model.up_data_structs.CollectionId key, string blockhash, CancellationToken token)
        {
            string parameters = RefungibleStorage.TokensMintedParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> TokensBurntParams
        ///  Amount of tokens burnt in a collection.
        /// </summary>
        public static string TokensBurntParams(Opal.NetApi.Generated.Model.up_data_structs.CollectionId key)
        {
            return RequestGenerator.GetStorage("Refungible", "TokensBurnt", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> TokensBurntDefault
        /// Default value as hex string
        /// </summary>
        public static string TokensBurntDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> TokensBurnt
        ///  Amount of tokens burnt in a collection.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> TokensBurnt(Opal.NetApi.Generated.Model.up_data_structs.CollectionId key, string blockhash, CancellationToken token)
        {
            string parameters = RefungibleStorage.TokensBurntParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> TokenPropertiesParams
        ///  Amount of pieces a refungible token is split into.
        /// </summary>
        public static string TokenPropertiesParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.up_data_structs.TokenId> key)
        {
            return RequestGenerator.GetStorage("Refungible", "TokenProperties", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> TokenPropertiesDefault
        /// Default value as hex string
        /// </summary>
        public static string TokenPropertiesDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> TokenProperties
        ///  Amount of pieces a refungible token is split into.
        /// </summary>
        public async Task<Opal.NetApi.Generated.Model.up_data_structs.PropertiesT2> TokenProperties(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.up_data_structs.TokenId> key, string blockhash, CancellationToken token)
        {
            string parameters = RefungibleStorage.TokenPropertiesParams(key);
            var result = await _client.GetStorageAsync<Opal.NetApi.Generated.Model.up_data_structs.PropertiesT2>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> TotalSupplyParams
        ///  Total amount of pieces for token
        /// </summary>
        public static string TotalSupplyParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.up_data_structs.TokenId> key)
        {
            return RequestGenerator.GetStorage("Refungible", "TotalSupply", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> TotalSupplyDefault
        /// Default value as hex string
        /// </summary>
        public static string TotalSupplyDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> TotalSupply
        ///  Total amount of pieces for token
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> TotalSupply(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.up_data_structs.TokenId> key, string blockhash, CancellationToken token)
        {
            string parameters = RefungibleStorage.TotalSupplyParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> OwnedParams
        ///  Used to enumerate tokens owned by account.
        /// </summary>
        public static string OwnedParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Opal.NetApi.Generated.Model.up_data_structs.TokenId> key)
        {
            return RequestGenerator.GetStorage("Refungible", "Owned", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> OwnedDefault
        /// Default value as hex string
        /// </summary>
        public static string OwnedDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Owned
        ///  Used to enumerate tokens owned by account.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> Owned(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Opal.NetApi.Generated.Model.up_data_structs.TokenId> key, string blockhash, CancellationToken token)
        {
            string parameters = RefungibleStorage.OwnedParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> AccountBalanceParams
        ///  Amount of tokens (not pieces) partially owned by an account within a collection.
        /// </summary>
        public static string AccountBalanceParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr> key)
        {
            return RequestGenerator.GetStorage("Refungible", "AccountBalance", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> AccountBalanceDefault
        /// Default value as hex string
        /// </summary>
        public static string AccountBalanceDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> AccountBalance
        ///  Amount of tokens (not pieces) partially owned by an account within a collection.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> AccountBalance(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr> key, string blockhash, CancellationToken token)
        {
            string parameters = RefungibleStorage.AccountBalanceParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> BalanceParams
        ///  Amount of token pieces owned by account.
        /// </summary>
        public static string BalanceParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.up_data_structs.TokenId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr> key)
        {
            return RequestGenerator.GetStorage("Refungible", "Balance", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> BalanceDefault
        /// Default value as hex string
        /// </summary>
        public static string BalanceDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> Balance
        ///  Amount of token pieces owned by account.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> Balance(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.up_data_structs.TokenId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr> key, string blockhash, CancellationToken token)
        {
            string parameters = RefungibleStorage.BalanceParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> AllowanceParams
        ///  Allowance set by a token owner for another user to perform one of certain transactions on a number of pieces of a token.
        /// </summary>
        public static string AllowanceParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.up_data_structs.TokenId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr> key)
        {
            return RequestGenerator.GetStorage("Refungible", "Allowance", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> AllowanceDefault
        /// Default value as hex string
        /// </summary>
        public static string AllowanceDefault()
        {
            return "0x00000000000000000000000000000000";
        }
        
        /// <summary>
        /// >> Allowance
        ///  Allowance set by a token owner for another user to perform one of certain transactions on a number of pieces of a token.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U128> Allowance(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.up_data_structs.TokenId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr> key, string blockhash, CancellationToken token)
        {
            string parameters = RefungibleStorage.AllowanceParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U128>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CollectionAllowanceParams
        ///  Spender set by a wallet owner that could perform certain transactions on all tokens in the wallet.
        /// </summary>
        public static string CollectionAllowanceParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr> key)
        {
            return RequestGenerator.GetStorage("Refungible", "CollectionAllowance", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> CollectionAllowanceDefault
        /// Default value as hex string
        /// </summary>
        public static string CollectionAllowanceDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CollectionAllowance
        ///  Spender set by a wallet owner that could perform certain transactions on all tokens in the wallet.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.Bool> CollectionAllowance(Substrate.NetApi.Model.Types.Base.BaseTuple<Opal.NetApi.Generated.Model.up_data_structs.CollectionId, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr, Opal.NetApi.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr> key, string blockhash, CancellationToken token)
        {
            string parameters = RefungibleStorage.CollectionAllowanceParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.Bool>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> RefungibleCalls
    /// </summary>
    public sealed class RefungibleCalls
    {
    }
    
    /// <summary>
    /// >> RefungibleConstants
    /// </summary>
    public sealed class RefungibleConstants
    {
    }
    
    /// <summary>
    /// >> RefungibleErrors
    /// </summary>
    public enum RefungibleErrors
    {
        
        /// <summary>
        /// >> NotRefungibleDataUsedToMintFungibleCollectionToken
        /// Not Refungible item data used to mint in Refungible collection.
        /// </summary>
        NotRefungibleDataUsedToMintFungibleCollectionToken,
        
        /// <summary>
        /// >> WrongRefungiblePieces
        /// Maximum refungibility exceeded.
        /// </summary>
        WrongRefungiblePieces,
        
        /// <summary>
        /// >> RepartitionWhileNotOwningAllPieces
        /// Refungible token can't be repartitioned by user who isn't owns all pieces.
        /// </summary>
        RepartitionWhileNotOwningAllPieces,
        
        /// <summary>
        /// >> RefungibleDisallowsNesting
        /// Refungible token can't nest other tokens.
        /// </summary>
        RefungibleDisallowsNesting,
        
        /// <summary>
        /// >> SettingPropertiesNotAllowed
        /// Setting item properties is not allowed.
        /// </summary>
        SettingPropertiesNotAllowed,
    }
}
