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


namespace Substrate.NetApi.Generated.Model.pallet_membership.pallet
{
    
    
    public enum Call
    {
        
        add_member = 0,
        
        remove_member = 1,
        
        swap_member = 2,
        
        reset_members = 3,
        
        change_key = 4,
        
        set_prime = 5,
        
        clear_prime = 6,
    }
    
    /// <summary>
    /// >> 243 - Variant[pallet_membership.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseTuple<Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseVoid>
    {
    }
}
