//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.NetApi.Generated.Model.polkadot_primitives.v6.executor_params
{
    
    
    /// <summary>
    /// >> ExecutorParam
    /// </summary>
    public enum ExecutorParam
    {
        
        /// <summary>
        /// >> MaxMemoryPages
        /// </summary>
        MaxMemoryPages = 1,
        
        /// <summary>
        /// >> StackLogicalMax
        /// </summary>
        StackLogicalMax = 2,
        
        /// <summary>
        /// >> StackNativeMax
        /// </summary>
        StackNativeMax = 3,
        
        /// <summary>
        /// >> PrecheckingMaxMemory
        /// </summary>
        PrecheckingMaxMemory = 4,
        
        /// <summary>
        /// >> PvfPrepTimeout
        /// </summary>
        PvfPrepTimeout = 5,
        
        /// <summary>
        /// >> PvfExecTimeout
        /// </summary>
        PvfExecTimeout = 6,
        
        /// <summary>
        /// >> WasmExtBulkMemory
        /// </summary>
        WasmExtBulkMemory = 7,
    }
    
    /// <summary>
    /// >> 324 - Variant[polkadot_primitives.v6.executor_params.ExecutorParam]
    /// </summary>
    public sealed class EnumExecutorParam : BaseEnumExt<ExecutorParam, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U64, BaseTuple<Substrate.NetApi.Generated.Model.polkadot_primitives.v6.EnumPvfPrepKind, Substrate.NetApi.Model.Types.Primitive.U64>, BaseTuple<Substrate.NetApi.Generated.Model.polkadot_primitives.v6.EnumPvfExecKind, Substrate.NetApi.Model.Types.Primitive.U64>, BaseVoid>
    {
    }
}
