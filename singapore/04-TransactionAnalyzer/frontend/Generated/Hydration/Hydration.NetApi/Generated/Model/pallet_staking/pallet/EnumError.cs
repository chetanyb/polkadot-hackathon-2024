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


namespace Hydration.NetApi.Generated.Model.pallet_staking.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> InsufficientBalance
        /// Balance is too low.
        /// </summary>
        InsufficientBalance = 0,
        
        /// <summary>
        /// >> InsufficientStake
        /// Staked amount is too low.
        /// </summary>
        InsufficientStake = 1,
        
        /// <summary>
        /// >> PositionNotFound
        /// Staking position has not been found.
        /// </summary>
        PositionNotFound = 2,
        
        /// <summary>
        /// >> MaxVotesReached
        /// Maximum amount of votes were reached for staking position.
        /// </summary>
        MaxVotesReached = 3,
        
        /// <summary>
        /// >> NotInitialized
        /// Staking is not initialized.
        /// </summary>
        NotInitialized = 4,
        
        /// <summary>
        /// >> AlreadyInitialized
        /// Staking is already initialized.
        /// </summary>
        AlreadyInitialized = 5,
        
        /// <summary>
        /// >> Arithmetic
        /// Arithmetic error.
        /// </summary>
        Arithmetic = 6,
        
        /// <summary>
        /// >> MissingPotBalance
        /// Pot's balance is zero.
        /// </summary>
        MissingPotBalance = 7,
        
        /// <summary>
        /// >> PositionAlreadyExists
        /// Account's position already exists.
        /// </summary>
        PositionAlreadyExists = 8,
        
        /// <summary>
        /// >> Forbidden
        /// Signer is not an owner of the staking position.
        /// </summary>
        Forbidden = 9,
        
        /// <summary>
        /// >> ExistingVotes
        /// Position contains registered votes.
        /// </summary>
        ExistingVotes = 10,
        
        /// <summary>
        /// >> ExistingProcessedVotes
        /// Position contains processed votes. Removed these votes first before increasing stake or claiming.
        /// </summary>
        ExistingProcessedVotes = 11,
        
        /// <summary>
        /// >> InconsistentState
        /// Action cannot be completed because unexpected error has occurred. This should be reported
        /// to protocol maintainers.
        /// </summary>
        InconsistentState = 12,
    }
    
    /// <summary>
    /// >> 602 - Variant[pallet_staking.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnumExt<Error, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid, Hydration.NetApi.Generated.Model.pallet_staking.pallet.EnumInconsistentStateError>
    {
    }
}
