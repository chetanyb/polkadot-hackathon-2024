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


namespace Bifrost.NetApi.Generated.Model.bifrost_slp.primitives.parachain_staking_primitives
{
    
    
    /// <summary>
    /// >> OneToManyDelegationAction
    /// </summary>
    public enum OneToManyDelegationAction
    {
        
        /// <summary>
        /// >> Revoke
        /// </summary>
        Revoke = 0,
        
        /// <summary>
        /// >> Decrease
        /// </summary>
        Decrease = 1,
    }
    
    /// <summary>
    /// >> 344 - Variant[bifrost_slp.primitives.parachain_staking_primitives.OneToManyDelegationAction]
    /// </summary>
    public sealed class EnumOneToManyDelegationAction : BaseEnumExt<OneToManyDelegationAction, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>
    {
    }
}
