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


namespace Substrate.NetApi.Generated.Model.pallet_nfts.types
{
    
    
    /// <summary>
    /// >> 358 - Composite[pallet_nfts.types.ItemMetadata]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ItemMetadata : BaseType
    {
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Substrate.NetApi.Generated.Model.pallet_nfts.types.ItemMetadataDeposit _deposit;
        
        /// <summary>
        /// >> data
        /// </summary>
        private Substrate.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7 _data;
        
        public Substrate.NetApi.Generated.Model.pallet_nfts.types.ItemMetadataDeposit Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public Substrate.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7 Data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }
        
        public override string TypeName()
        {
            return "ItemMetadata";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Deposit.Encode());
            result.AddRange(Data.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Deposit = new Substrate.NetApi.Generated.Model.pallet_nfts.types.ItemMetadataDeposit();
            Deposit.Decode(byteArray, ref p);
            Data = new Substrate.NetApi.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7();
            Data.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
