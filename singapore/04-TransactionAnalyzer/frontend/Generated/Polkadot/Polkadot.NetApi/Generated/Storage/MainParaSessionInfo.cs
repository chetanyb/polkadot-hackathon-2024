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


namespace Polkadot.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> ParaSessionInfoStorage
    /// </summary>
    public sealed class ParaSessionInfoStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> ParaSessionInfoStorage Constructor
        /// </summary>
        public ParaSessionInfoStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaSessionInfo", "AssignmentKeysUnsafe"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.assignment_app.Public>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaSessionInfo", "EarliestStoredSession"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaSessionInfo", "Sessions"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.SessionInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaSessionInfo", "AccountKeys"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("ParaSessionInfo", "SessionExecutorParams"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParams)));
        }
        
        /// <summary>
        /// >> AssignmentKeysUnsafeParams
        ///  Assignment keys for the current session.
        ///  Note that this API is private due to it being prone to 'off-by-one' at session boundaries.
        ///  When in doubt, use `Sessions` API instead.
        /// </summary>
        public static string AssignmentKeysUnsafeParams()
        {
            return RequestGenerator.GetStorage("ParaSessionInfo", "AssignmentKeysUnsafe", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> AssignmentKeysUnsafeDefault
        /// Default value as hex string
        /// </summary>
        public static string AssignmentKeysUnsafeDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> AssignmentKeysUnsafe
        ///  Assignment keys for the current session.
        ///  Note that this API is private due to it being prone to 'off-by-one' at session boundaries.
        ///  When in doubt, use `Sessions` API instead.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.assignment_app.Public>> AssignmentKeysUnsafe(string blockhash, CancellationToken token)
        {
            string parameters = ParaSessionInfoStorage.AssignmentKeysUnsafeParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.assignment_app.Public>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> EarliestStoredSessionParams
        ///  The earliest session for which previous session info is stored.
        /// </summary>
        public static string EarliestStoredSessionParams()
        {
            return RequestGenerator.GetStorage("ParaSessionInfo", "EarliestStoredSession", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> EarliestStoredSessionDefault
        /// Default value as hex string
        /// </summary>
        public static string EarliestStoredSessionDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> EarliestStoredSession
        ///  The earliest session for which previous session info is stored.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> EarliestStoredSession(string blockhash, CancellationToken token)
        {
            string parameters = ParaSessionInfoStorage.EarliestStoredSessionParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SessionsParams
        ///  Session information in a rolling window.
        ///  Should have an entry in range `EarliestStoredSession..=CurrentSessionIndex`.
        ///  Does not have any entries before the session index in the first session change notification.
        /// </summary>
        public static string SessionsParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("ParaSessionInfo", "Sessions", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SessionsDefault
        /// Default value as hex string
        /// </summary>
        public static string SessionsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Sessions
        ///  Session information in a rolling window.
        ///  Should have an entry in range `EarliestStoredSession..=CurrentSessionIndex`.
        ///  Does not have any entries before the session index in the first session change notification.
        /// </summary>
        public async Task<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.SessionInfo> Sessions(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = ParaSessionInfoStorage.SessionsParams(key);
            var result = await _client.GetStorageAsync<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.SessionInfo>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> AccountKeysParams
        ///  The validator account keys of the validators actively participating in parachain consensus.
        /// </summary>
        public static string AccountKeysParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("ParaSessionInfo", "AccountKeys", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> AccountKeysDefault
        /// Default value as hex string
        /// </summary>
        public static string AccountKeysDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> AccountKeys
        ///  The validator account keys of the validators actively participating in parachain consensus.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32>> AccountKeys(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = ParaSessionInfoStorage.AccountKeysParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Base.BaseVec<Polkadot.NetApi.Generated.Model.sp_core.crypto.AccountId32>>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> SessionExecutorParamsParams
        ///  Executor parameter set for a given session index
        /// </summary>
        public static string SessionExecutorParamsParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("ParaSessionInfo", "SessionExecutorParams", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> SessionExecutorParamsDefault
        /// Default value as hex string
        /// </summary>
        public static string SessionExecutorParamsDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> SessionExecutorParams
        ///  Executor parameter set for a given session index
        /// </summary>
        public async Task<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParams> SessionExecutorParams(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = ParaSessionInfoStorage.SessionExecutorParamsParams(key);
            var result = await _client.GetStorageAsync<Polkadot.NetApi.Generated.Model.polkadot_primitives.v6.executor_params.ExecutorParams>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> ParaSessionInfoCalls
    /// </summary>
    public sealed class ParaSessionInfoCalls
    {
    }
    
    /// <summary>
    /// >> ParaSessionInfoConstants
    /// </summary>
    public sealed class ParaSessionInfoConstants
    {
    }
}
