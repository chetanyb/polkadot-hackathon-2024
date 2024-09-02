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


namespace Substrate.NetApi.Generated.Model.polkadot_primitives.v2
{
    
    
    /// <summary>
    /// >> 658 - Composite[polkadot_primitives.v2.ParathreadClaim]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ParathreadClaim : BaseType
    {
        
        /// <summary>
        /// >> Id
        /// </summary>
        private Substrate.NetApi.Generated.Model.polkadot_parachain.primitives.Id _id;
        
        /// <summary>
        /// >> CollatorId
        /// </summary>
        private Substrate.NetApi.Generated.Model.polkadot_primitives.v2.collator_app.Public _collatorId;
        
        public Substrate.NetApi.Generated.Model.polkadot_parachain.primitives.Id Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        
        public Substrate.NetApi.Generated.Model.polkadot_primitives.v2.collator_app.Public CollatorId
        {
            get
            {
                return this._collatorId;
            }
            set
            {
                this._collatorId = value;
            }
        }
        
        public override string TypeName()
        {
            return "ParathreadClaim";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Id.Encode());
            result.AddRange(CollatorId.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Id = new Substrate.NetApi.Generated.Model.polkadot_parachain.primitives.Id();
            Id.Decode(byteArray, ref p);
            CollatorId = new Substrate.NetApi.Generated.Model.polkadot_primitives.v2.collator_app.Public();
            CollatorId.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
