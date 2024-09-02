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


namespace Bajun.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> AssetRegistryStorage
    /// </summary>
    public sealed class AssetRegistryStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> AssetRegistryStorage Constructor
        /// </summary>
        public AssetRegistryStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AssetRegistry", "AssetIdLocation"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("AssetRegistry", "AssetLocationId"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
        }
        
        /// <summary>
        /// >> AssetIdLocationParams
        /// </summary>
        public static string AssetIdLocationParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("AssetRegistry", "AssetIdLocation", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AssetIdLocationDefault
        /// Default value as hex string
        /// </summary>
        public static string AssetIdLocationDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> AssetIdLocation
        /// </summary>
        public async Task<Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location> AssetIdLocation(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = AssetRegistryStorage.AssetIdLocationParams(key);
            var result = await _client.GetStorageAsync<Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> AssetLocationIdParams
        /// </summary>
        public static string AssetLocationIdParams(Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location key)
        {
            return RequestGenerator.GetStorage("AssetRegistry", "AssetLocationId", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AssetLocationIdDefault
        /// Default value as hex string
        /// </summary>
        public static string AssetLocationIdDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> AssetLocationId
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> AssetLocationId(Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location key, string blockhash, CancellationToken token)
        {
            string parameters = AssetRegistryStorage.AssetLocationIdParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> AssetRegistryCalls
    /// </summary>
    public sealed class AssetRegistryCalls
    {
        
        /// <summary>
        /// >> register_reserve_asset
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RegisterReserveAsset(Substrate.NetApi.Model.Types.Primitive.U32 asset_id, Bajun.NetApi.Generated.Model.staging_xcm.v4.location.Location asset_location)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_id.Encode());
            byteArray.AddRange(asset_location.Encode());
            return new Method(91, "AssetRegistry", 0, "register_reserve_asset", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unregister_reserve_asset
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method UnregisterReserveAsset(Substrate.NetApi.Model.Types.Primitive.U32 asset_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(asset_id.Encode());
            return new Method(91, "AssetRegistry", 1, "unregister_reserve_asset", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> AssetRegistryConstants
    /// </summary>
    public sealed class AssetRegistryConstants
    {
    }
    
    /// <summary>
    /// >> AssetRegistryErrors
    /// </summary>
    public enum AssetRegistryErrors
    {
        
        /// <summary>
        /// >> AssetAlreadyRegistered
        /// The Asset ID is already registered
        /// </summary>
        AssetAlreadyRegistered,
        
        /// <summary>
        /// >> AssetDoesNotExist
        /// The Asset ID does not exist
        /// </summary>
        AssetDoesNotExist,
        
        /// <summary>
        /// >> AssetIsNotRegistered
        /// The Asset ID is not registered
        /// </summary>
        AssetIsNotRegistered,
        
        /// <summary>
        /// >> WrongLocation
        /// Invalid Location
        /// </summary>
        WrongLocation,
    }
}
