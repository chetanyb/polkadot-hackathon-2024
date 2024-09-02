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


namespace Hydration.NetApi.Generated.Model.staging_xcm.v4.asset
{
    
    
    /// <summary>
    /// >> 177 - Composite[staging_xcm.v4.asset.Asset]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Asset : BaseType
    {
        
        /// <summary>
        /// >> id
        /// </summary>
        public Hydration.NetApi.Generated.Model.staging_xcm.v4.asset.AssetId Id { get; set; }
        /// <summary>
        /// >> fun
        /// </summary>
        public Hydration.NetApi.Generated.Model.staging_xcm.v4.asset.EnumFungibility Fun { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Asset";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Id.Encode());
            result.AddRange(Fun.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Id = new Hydration.NetApi.Generated.Model.staging_xcm.v4.asset.AssetId();
            Id.Decode(byteArray, ref p);
            Fun = new Hydration.NetApi.Generated.Model.staging_xcm.v4.asset.EnumFungibility();
            Fun.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
