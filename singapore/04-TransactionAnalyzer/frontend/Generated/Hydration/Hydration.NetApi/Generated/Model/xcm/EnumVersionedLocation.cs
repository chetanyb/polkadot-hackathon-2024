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


namespace Hydration.NetApi.Generated.Model.xcm
{
    
    
    /// <summary>
    /// >> VersionedLocation
    /// </summary>
    public enum VersionedLocation
    {
        
        /// <summary>
        /// >> V2
        /// </summary>
        V2 = 1,
        
        /// <summary>
        /// >> V3
        /// </summary>
        V3 = 3,
        
        /// <summary>
        /// >> V4
        /// </summary>
        V4 = 4,
    }
    
    /// <summary>
    /// >> 219 - Variant[xcm.VersionedLocation]
    /// </summary>
    public sealed class EnumVersionedLocation : BaseEnumExt<VersionedLocation, BaseVoid, Hydration.NetApi.Generated.Model.xcm.v2.multilocation.MultiLocation, BaseVoid, Hydration.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Hydration.NetApi.Generated.Model.staging_xcm.v4.location.Location>
    {
    }
}
