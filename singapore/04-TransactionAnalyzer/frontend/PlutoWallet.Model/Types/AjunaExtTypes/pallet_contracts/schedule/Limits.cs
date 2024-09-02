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


namespace Substrate.NetApi.Generated.Model.pallet_contracts.schedule
{
    
    
    /// <summary>
    /// >> 267 - Composite[pallet_contracts.schedule.Limits]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Limits : BaseType
    {
        
        /// <summary>
        /// >> event_topics
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _eventTopics;
        
        /// <summary>
        /// >> globals
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _globals;
        
        /// <summary>
        /// >> locals
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _locals;
        
        /// <summary>
        /// >> parameters
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _parameters;
        
        /// <summary>
        /// >> memory_pages
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _memoryPages;
        
        /// <summary>
        /// >> table_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _tableSize;
        
        /// <summary>
        /// >> br_table_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _brTableSize;
        
        /// <summary>
        /// >> subject_len
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _subjectLen;
        
        /// <summary>
        /// >> payload_len
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _payloadLen;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 EventTopics
        {
            get
            {
                return this._eventTopics;
            }
            set
            {
                this._eventTopics = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Globals
        {
            get
            {
                return this._globals;
            }
            set
            {
                this._globals = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Locals
        {
            get
            {
                return this._locals;
            }
            set
            {
                this._locals = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Parameters
        {
            get
            {
                return this._parameters;
            }
            set
            {
                this._parameters = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MemoryPages
        {
            get
            {
                return this._memoryPages;
            }
            set
            {
                this._memoryPages = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 TableSize
        {
            get
            {
                return this._tableSize;
            }
            set
            {
                this._tableSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 BrTableSize
        {
            get
            {
                return this._brTableSize;
            }
            set
            {
                this._brTableSize = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 SubjectLen
        {
            get
            {
                return this._subjectLen;
            }
            set
            {
                this._subjectLen = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 PayloadLen
        {
            get
            {
                return this._payloadLen;
            }
            set
            {
                this._payloadLen = value;
            }
        }
        
        public override string TypeName()
        {
            return "Limits";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(EventTopics.Encode());
            result.AddRange(Globals.Encode());
            result.AddRange(Locals.Encode());
            result.AddRange(Parameters.Encode());
            result.AddRange(MemoryPages.Encode());
            result.AddRange(TableSize.Encode());
            result.AddRange(BrTableSize.Encode());
            result.AddRange(SubjectLen.Encode());
            result.AddRange(PayloadLen.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            EventTopics = new Substrate.NetApi.Model.Types.Primitive.U32();
            EventTopics.Decode(byteArray, ref p);
            Globals = new Substrate.NetApi.Model.Types.Primitive.U32();
            Globals.Decode(byteArray, ref p);
            Locals = new Substrate.NetApi.Model.Types.Primitive.U32();
            Locals.Decode(byteArray, ref p);
            Parameters = new Substrate.NetApi.Model.Types.Primitive.U32();
            Parameters.Decode(byteArray, ref p);
            MemoryPages = new Substrate.NetApi.Model.Types.Primitive.U32();
            MemoryPages.Decode(byteArray, ref p);
            TableSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            TableSize.Decode(byteArray, ref p);
            BrTableSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            BrTableSize.Decode(byteArray, ref p);
            SubjectLen = new Substrate.NetApi.Model.Types.Primitive.U32();
            SubjectLen.Decode(byteArray, ref p);
            PayloadLen = new Substrate.NetApi.Model.Types.Primitive.U32();
            PayloadLen.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
