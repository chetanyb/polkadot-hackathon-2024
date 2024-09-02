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


namespace Substrate.NetApi.Generated.Model.pallet_democracy.pallet
{
    
    
    public enum Call
    {
        
        propose = 0,
        
        second = 1,
        
        vote = 2,
        
        emergency_cancel = 3,
        
        external_propose = 4,
        
        external_propose_majority = 5,
        
        external_propose_default = 6,
        
        fast_track = 7,
        
        veto_external = 8,
        
        cancel_referendum = 9,
        
        @delegate = 10,
        
        undelegate = 11,
        
        clear_public_proposals = 12,
        
        unlock = 13,
        
        remove_vote = 14,
        
        remove_other_vote = 15,
        
        blacklist = 16,
        
        cancel_proposal = 17,
    }
    
    /// <summary>
    /// >> 234 - Variant[pallet_democracy.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Generated.Model.pallet_democracy.vote.EnumAccountVote>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded, Substrate.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded, Substrate.NetApi.Generated.Model.frame_support.traits.preimages.EnumBounded, BaseTuple<Substrate.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Generated.Model.pallet_democracy.conviction.EnumConviction, Substrate.NetApi.Model.Types.Primitive.U128>, BaseVoid, BaseVoid, Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
