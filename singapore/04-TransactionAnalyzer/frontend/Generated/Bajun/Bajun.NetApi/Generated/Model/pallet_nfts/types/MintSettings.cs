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
    /// >> 429 - Composite[pallet_nfts.types.MintSettings]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MintSettings : BaseType
    {
        
        /// <summary>
        /// >> mint_type
        /// </summary>
        public Bajun.NetApi.Generated.Model.pallet_nfts.types.EnumMintType MintType { get; set; }
        /// <summary>
        /// >> price
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128> Price { get; set; }
        /// <summary>
        /// >> start_block
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> StartBlock { get; set; }
        /// <summary>
        /// >> end_block
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32> EndBlock { get; set; }
        /// <summary>
        /// >> default_item_settings
        /// </summary>
        public Bajun.NetApi.Generated.Model.pallet_nfts.types.BitFlagsT2 DefaultItemSettings { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "MintSettings";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MintType.Encode());
            result.AddRange(Price.Encode());
            result.AddRange(StartBlock.Encode());
            result.AddRange(EndBlock.Encode());
            result.AddRange(DefaultItemSettings.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MintType = new Bajun.NetApi.Generated.Model.pallet_nfts.types.EnumMintType();
            MintType.Decode(byteArray, ref p);
            Price = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U128>();
            Price.Decode(byteArray, ref p);
            StartBlock = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            StartBlock.Decode(byteArray, ref p);
            EndBlock = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Primitive.U32>();
            EndBlock.Decode(byteArray, ref p);
            DefaultItemSettings = new Bajun.NetApi.Generated.Model.pallet_nfts.types.BitFlagsT2();
            DefaultItemSettings.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
