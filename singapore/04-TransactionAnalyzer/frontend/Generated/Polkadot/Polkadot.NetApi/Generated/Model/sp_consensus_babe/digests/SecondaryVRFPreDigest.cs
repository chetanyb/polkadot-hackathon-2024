//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Polkadot.NetApi.Generated.Model.sp_consensus_babe.digests
{
    
    
    /// <summary>
    /// >> 564 - Composite[sp_consensus_babe.digests.SecondaryVRFPreDigest]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SecondaryVRFPreDigest : BaseType
    {
        
        /// <summary>
        /// >> authority_index
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 AuthorityIndex { get; set; }
        /// <summary>
        /// >> slot
        /// </summary>
        public Polkadot.NetApi.Generated.Model.sp_consensus_slots.Slot Slot { get; set; }
        /// <summary>
        /// >> vrf_signature
        /// </summary>
        public Polkadot.NetApi.Generated.Model.sp_core.sr25519.vrf.VrfSignature VrfSignature { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "SecondaryVRFPreDigest";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(AuthorityIndex.Encode());
            result.AddRange(Slot.Encode());
            result.AddRange(VrfSignature.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            AuthorityIndex = new Substrate.NetApi.Model.Types.Primitive.U32();
            AuthorityIndex.Decode(byteArray, ref p);
            Slot = new Polkadot.NetApi.Generated.Model.sp_consensus_slots.Slot();
            Slot.Decode(byteArray, ref p);
            VrfSignature = new Polkadot.NetApi.Generated.Model.sp_core.sr25519.vrf.VrfSignature();
            VrfSignature.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
