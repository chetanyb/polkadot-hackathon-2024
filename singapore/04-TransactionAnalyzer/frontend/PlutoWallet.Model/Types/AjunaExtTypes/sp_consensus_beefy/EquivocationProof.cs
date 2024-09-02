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


namespace Substrate.NetApi.Generated.Model.sp_consensus_beefy
{
    
    
    /// <summary>
    /// >> 469 - Composite[sp_consensus_beefy.EquivocationProof]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class EquivocationProof : BaseType
    {
        
        /// <summary>
        /// >> first
        /// </summary>
        public Substrate.NetApi.Generated.Model.sp_consensus_beefy.VoteMessage First { get; set; }
        /// <summary>
        /// >> second
        /// </summary>
        public Substrate.NetApi.Generated.Model.sp_consensus_beefy.VoteMessage Second { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "EquivocationProof";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(First.Encode());
            result.AddRange(Second.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            First = new Substrate.NetApi.Generated.Model.sp_consensus_beefy.VoteMessage();
            First.Decode(byteArray, ref p);
            Second = new Substrate.NetApi.Generated.Model.sp_consensus_beefy.VoteMessage();
            Second.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
