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


namespace Opal.NetApi.Generated.Model.xcm.v3.traits
{
    
    
    /// <summary>
    /// >> Outcome
    /// </summary>
    public enum Outcome
    {
        
        /// <summary>
        /// >> Complete
        /// </summary>
        Complete = 0,
        
        /// <summary>
        /// >> Incomplete
        /// </summary>
        Incomplete = 1,
        
        /// <summary>
        /// >> Error
        /// </summary>
        Error = 2,
    }
    
    /// <summary>
    /// >> 365 - Variant[xcm.v3.traits.Outcome]
    /// </summary>
    public sealed class EnumOutcome : BaseEnumExt<Outcome, Opal.NetApi.Generated.Model.sp_weights.weight_v2.Weight, BaseTuple<Opal.NetApi.Generated.Model.sp_weights.weight_v2.Weight, Opal.NetApi.Generated.Model.xcm.v3.traits.EnumError>, Opal.NetApi.Generated.Model.xcm.v3.traits.EnumError>
    {
    }
}
