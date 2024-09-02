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


namespace Bajun.NetApi.Generated.Model.cumulus_pallet_parachain_system.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> set_validation_data
        /// Set the current validation data.
        /// 
        /// This should be invoked exactly once per block. It will panic at the finalization
        /// phase if the call was not invoked.
        /// 
        /// The dispatch origin for this call must be `Inherent`
        /// 
        /// As a side effect, this function upgrades the current validation function
        /// if the appropriate time has come.
        /// </summary>
        set_validation_data = 0,
        
        /// <summary>
        /// >> sudo_send_upward_message
        /// </summary>
        sudo_send_upward_message = 1,
        
        /// <summary>
        /// >> authorize_upgrade
        /// Authorize an upgrade to a given `code_hash` for the runtime. The runtime can be supplied
        /// later.
        /// 
        /// The `check_version` parameter sets a boolean flag for whether or not the runtime's spec
        /// version and name should be verified on upgrade. Since the authorization only has a hash,
        /// it cannot actually perform the verification.
        /// 
        /// This call requires Root origin.
        /// </summary>
        authorize_upgrade = 2,
        
        /// <summary>
        /// >> enact_authorized_upgrade
        /// Provide the preimage (runtime binary) `code` for an upgrade that has been authorized.
        /// 
        /// If the authorization required a version check, this call will ensure the spec name
        /// remains unchanged and that the spec version has increased.
        /// 
        /// Note that this function will not apply the new `code`, but only attempt to schedule the
        /// upgrade with the Relay Chain.
        /// 
        /// All origins are allowed.
        /// </summary>
        enact_authorized_upgrade = 3,
    }
    
    /// <summary>
    /// >> 255 - Variant[cumulus_pallet_parachain_system.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Bajun.NetApi.Generated.Model.cumulus_primitives_parachain_inherent.ParachainInherentData, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, BaseTuple<Bajun.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.Bool>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>
    {
    }
}
