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


namespace Substrate.NetApi.Generated.Model.frame_system.extensions.check_mortality
{
    
    
    /// <summary>
    /// >> 733 - Composite[frame_system.extensions.check_mortality.CheckMortality]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CheckMortality : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private Substrate.NetApi.Generated.Model.sp_runtime.generic.era.EnumEra _value;
        
        public Substrate.NetApi.Generated.Model.sp_runtime.generic.era.EnumEra Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "CheckMortality";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new Substrate.NetApi.Generated.Model.sp_runtime.generic.era.EnumEra();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
