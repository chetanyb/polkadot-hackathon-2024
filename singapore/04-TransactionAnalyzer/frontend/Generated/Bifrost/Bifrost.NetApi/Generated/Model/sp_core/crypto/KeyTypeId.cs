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


namespace Bifrost.NetApi.Generated.Model.sp_core.crypto
{
    
    
    /// <summary>
    /// >> 578 - Composite[sp_core.crypto.KeyTypeId]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class KeyTypeId : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        public Bifrost.NetApi.Generated.Types.Base.Arr4U8 Value { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "KeyTypeId";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new Bifrost.NetApi.Generated.Types.Base.Arr4U8();
            Value.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
