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


namespace Bifrost.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> XcmInterfaceStorage
    /// </summary>
    public sealed class XcmInterfaceStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> XcmInterfaceStorage Constructor
        /// </summary>
        public XcmInterfaceStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("XcmInterface", "XcmWeightAndFee"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.EnumXcmOperationType>), typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U128>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("XcmInterface", "CurrentNonce"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
        }
        
        /// <summary>
        /// >> XcmWeightAndFeeParams
        ///  The dest weight limit and fee for execution XCM msg sent by XcmInterface. Must be
        ///  sufficient, otherwise the execution of XCM msg on relaychain will fail.
        /// 
        ///  XcmWeightAndFee: map: XcmOperationType => (Weight, Balance)
        /// </summary>
        public static string XcmWeightAndFeeParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.EnumXcmOperationType> key)
        {
            return RequestGenerator.GetStorage("XcmInterface", "XcmWeightAndFee", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, key.Value);
        }
        
        /// <summary>
        /// >> XcmWeightAndFeeDefault
        /// Default value as hex string
        /// </summary>
        public static string XcmWeightAndFeeDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> XcmWeightAndFee
        ///  The dest weight limit and fee for execution XCM msg sent by XcmInterface. Must be
        ///  sufficient, otherwise the execution of XCM msg on relaychain will fail.
        /// 
        ///  XcmWeightAndFee: map: XcmOperationType => (Weight, Balance)
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U128>> XcmWeightAndFee(Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.EnumXcmOperationType> key, string blockhash, CancellationToken token)
        {
            string parameters = XcmInterfaceStorage.XcmWeightAndFeeParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U128>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> CurrentNonceParams
        /// </summary>
        public static string CurrentNonceParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("XcmInterface", "CurrentNonce", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CurrentNonceDefault
        /// Default value as hex string
        /// </summary>
        public static string CurrentNonceDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> CurrentNonce
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> CurrentNonce(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = XcmInterfaceStorage.CurrentNonceParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> XcmInterfaceCalls
    /// </summary>
    public sealed class XcmInterfaceCalls
    {
        
        /// <summary>
        /// >> update_xcm_dest_weight_and_fee
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method UpdateXcmDestWeightAndFee(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId, Bifrost.NetApi.Generated.Model.bifrost_primitives.EnumXcmOperationType, Bifrost.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Substrate.NetApi.Model.Types.Primitive.U128>> updates)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(updates.Encode());
            return new Method(117, "XcmInterface", 0, "update_xcm_dest_weight_and_fee", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> transfer_statemine_assets
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method TransferStatemineAssets(Substrate.NetApi.Model.Types.Primitive.U128 amount, Substrate.NetApi.Model.Types.Primitive.U32 asset_id, Substrate.NetApi.Model.Types.Base.BaseOpt<Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32> dest)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(amount.Encode());
            byteArray.AddRange(asset_id.Encode());
            byteArray.AddRange(dest.Encode());
            return new Method(117, "XcmInterface", 1, "transfer_statemine_assets", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> XcmInterfaceConstants
    /// </summary>
    public sealed class XcmInterfaceConstants
    {
        
        /// <summary>
        /// >> RelaychainCurrencyId
        ///  The currency id of the RelayChain
        /// </summary>
        public Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId RelaychainCurrencyId()
        {
            var result = new Bifrost.NetApi.Generated.Model.bifrost_primitives.currency.EnumCurrencyId();
            result.Create("0x0800");
            return result;
        }
        
        /// <summary>
        /// >> ParachainSovereignAccount
        ///  The account of parachain on the relaychain.
        /// </summary>
        public Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32 ParachainSovereignAccount()
        {
            var result = new Bifrost.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            result.Create("0x70617261EE070000000000000000000000000000000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> RelayNetwork
        /// </summary>
        public Bifrost.NetApi.Generated.Model.staging_xcm.v4.junction.EnumNetworkId RelayNetwork()
        {
            var result = new Bifrost.NetApi.Generated.Model.staging_xcm.v4.junction.EnumNetworkId();
            result.Create("0x02");
            return result;
        }
        
        /// <summary>
        /// >> ParachainId
        /// </summary>
        public Bifrost.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id ParachainId()
        {
            var result = new Bifrost.NetApi.Generated.Model.polkadot_parachain_primitives.primitives.Id();
            result.Create("0xEE070000");
            return result;
        }
        
        /// <summary>
        /// >> CallBackTimeOut
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 CallBackTimeOut()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x0A000000");
            return result;
        }
    }
    
    /// <summary>
    /// >> XcmInterfaceErrors
    /// </summary>
    public enum XcmInterfaceErrors
    {
        
        /// <summary>
        /// >> FeeConvertFailed
        /// </summary>
        FeeConvertFailed,
        
        /// <summary>
        /// >> XcmExecutionFailed
        /// </summary>
        XcmExecutionFailed,
        
        /// <summary>
        /// >> XcmSendFailed
        /// </summary>
        XcmSendFailed,
        
        /// <summary>
        /// >> OperationWeightAndFeeNotExist
        /// </summary>
        OperationWeightAndFeeNotExist,
        
        /// <summary>
        /// >> FailToConvert
        /// </summary>
        FailToConvert,
        
        /// <summary>
        /// >> UnweighableMessage
        /// </summary>
        UnweighableMessage,
        
        /// <summary>
        /// >> LocalExecutionIncomplete
        /// </summary>
        LocalExecutionIncomplete,
    }
}
