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


namespace Bajun.NetApi.Generated.Model.pallet_nfts.types
{
    
    
    /// <summary>
    /// >> 433 - Composite[pallet_nfts.types.DestroyWitness]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DestroyWitness : BaseType
    {
        
        /// <summary>
        /// >> item_metadatas
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> ItemMetadatas { get; set; }
        /// <summary>
        /// >> item_configs
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> ItemConfigs { get; set; }
        /// <summary>
        /// >> attributes
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> Attributes { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "DestroyWitness";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ItemMetadatas.Encode());
            result.AddRange(ItemConfigs.Encode());
            result.AddRange(Attributes.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ItemMetadatas = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            ItemMetadatas.Decode(byteArray, ref p);
            ItemConfigs = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            ItemConfigs.Decode(byteArray, ref p);
            Attributes = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            Attributes.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
