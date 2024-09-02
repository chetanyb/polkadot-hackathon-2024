//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Bajun.NetApi.Generated.Model.orml_xtokens.module
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> AssetHasNoReserve
        /// Asset has no reserve location.
        /// </summary>
        AssetHasNoReserve = 0,
        
        /// <summary>
        /// >> NotCrossChainTransfer
        /// Not cross-chain transfer.
        /// </summary>
        NotCrossChainTransfer = 1,
        
        /// <summary>
        /// >> InvalidDest
        /// Invalid transfer destination.
        /// </summary>
        InvalidDest = 2,
        
        /// <summary>
        /// >> NotCrossChainTransferableCurrency
        /// Currency is not cross-chain transferable.
        /// </summary>
        NotCrossChainTransferableCurrency = 3,
        
        /// <summary>
        /// >> UnweighableMessage
        /// The message's weight could not be determined.
        /// </summary>
        UnweighableMessage = 4,
        
        /// <summary>
        /// >> XcmExecutionFailed
        /// XCM execution failed.
        /// </summary>
        XcmExecutionFailed = 5,
        
        /// <summary>
        /// >> CannotReanchor
        /// Could not re-anchor the assets to declare the fees for the
        /// destination chain.
        /// </summary>
        CannotReanchor = 6,
        
        /// <summary>
        /// >> InvalidAncestry
        /// Could not get ancestry of asset reserve location.
        /// </summary>
        InvalidAncestry = 7,
        
        /// <summary>
        /// >> InvalidAsset
        /// The Asset is invalid.
        /// </summary>
        InvalidAsset = 8,
        
        /// <summary>
        /// >> DestinationNotInvertible
        /// The destination `Location` provided cannot be inverted.
        /// </summary>
        DestinationNotInvertible = 9,
        
        /// <summary>
        /// >> BadVersion
        /// The version of the `Versioned` value used is not able to be
        /// interpreted.
        /// </summary>
        BadVersion = 10,
        
        /// <summary>
        /// >> DistinctReserveForAssetAndFee
        /// We tried sending distinct asset and fee but they have different
        /// reserve chains.
        /// </summary>
        DistinctReserveForAssetAndFee = 11,
        
        /// <summary>
        /// >> ZeroFee
        /// The fee is zero.
        /// </summary>
        ZeroFee = 12,
        
        /// <summary>
        /// >> ZeroAmount
        /// The transfering asset amount is zero.
        /// </summary>
        ZeroAmount = 13,
        
        /// <summary>
        /// >> TooManyAssetsBeingSent
        /// The number of assets to be sent is over the maximum.
        /// </summary>
        TooManyAssetsBeingSent = 14,
        
        /// <summary>
        /// >> AssetIndexNonExistent
        /// The specified index does not exist in a Assets struct.
        /// </summary>
        AssetIndexNonExistent = 15,
        
        /// <summary>
        /// >> FeeNotEnough
        /// Fee is not enough.
        /// </summary>
        FeeNotEnough = 16,
        
        /// <summary>
        /// >> NotSupportedLocation
        /// Not supported Location
        /// </summary>
        NotSupportedLocation = 17,
        
        /// <summary>
        /// >> MinXcmFeeNotDefined
        /// MinXcmFee not registered for certain reserve location
        /// </summary>
        MinXcmFeeNotDefined = 18,
        
        /// <summary>
        /// >> RateLimited
        /// Asset transfer is limited by RateLimiter.
        /// </summary>
        RateLimited = 19,
    }
    
    /// <summary>
    /// >> 562 - Variant[orml_xtokens.module.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
