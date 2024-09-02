// Copyright (C) Moondance Labs Ltd.
// This file is part of Tanssi.

// Tanssi is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// Tanssi is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with Tanssi.  If not, see <http://www.gnu.org/licenses/>


//! Autogenerated weights for pallet_xcm_core_buyer
//!
//! THIS FILE WAS AUTO-GENERATED USING THE SUBSTRATE BENCHMARK CLI VERSION 4.0.0-dev
//! DATE: 2024-05-29, STEPS: `50`, REPEAT: `20`, LOW RANGE: `[]`, HIGH RANGE: `[]`
//! WORST CASE MAP SIZE: `1000000`
//! HOSTNAME: `Parths-MBP-Work`, CPU: `<UNKNOWN>`
//! EXECUTION: , WASM-EXECUTION: Compiled, CHAIN: Some("dev"), DB CACHE: 1024

// Executed Command:
// ./target/release/tanssi-node
// benchmark
// pallet
// --execution=wasm
// --wasm-execution=compiled
// --pallet
// pallet_xcm_core_buyer
// --extrinsic
// *
// --chain=dev
// --steps
// 50
// --repeat
// 20
// --template=benchmarking/frame-weight-pallet-template.hbs
// --json-file
// raw.json
// --output
// tmp/pallet_xcm_core_buyer.rs

#![cfg_attr(rustfmt, rustfmt_skip)]
#![allow(unused_parens)]
#![allow(unused_imports)]

use frame_support::{traits::Get, weights::{Weight, constants::RocksDbWeight}};
use sp_std::marker::PhantomData;

/// Weight functions needed for pallet_xcm_core_buyer.
pub trait WeightInfo {
	fn buy_core() -> Weight;
	fn force_buy_core() -> Weight;
	fn query_response() -> Weight;
	fn clean_up_expired_in_flight_orders(x: u32, ) -> Weight;
	fn clean_up_expired_pending_blocks(x: u32, ) -> Weight;
	fn set_relay_xcm_weight_config() -> Weight;
	fn set_relay_chain() -> Weight;
}

/// Weights for pallet_xcm_core_buyer using the Substrate node and recommended hardware.
pub struct SubstrateWeight<T>(PhantomData<T>);
impl<T: frame_system::Config> WeightInfo for SubstrateWeight<T> {
	/// Storage: `XcmCoreBuyer::CollatorSignatureNonce` (r:1 w:1)
	/// Proof: `XcmCoreBuyer::CollatorSignatureNonce` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::InFlightOrders` (r:1 w:1)
	/// Proof: `XcmCoreBuyer::InFlightOrders` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::PendingBlocks` (r:1 w:0)
	/// Proof: `XcmCoreBuyer::PendingBlocks` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `Registrar::ParathreadParams` (r:1 w:0)
	/// Proof: `Registrar::ParathreadParams` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `AuthorNoting::LatestAuthor` (r:1 w:0)
	/// Proof: `AuthorNoting::LatestAuthor` (`max_values`: None, `max_size`: Some(64), added: 2539, mode: `MaxEncodedLen`)
	/// Storage: `XcmCoreBuyer::RelayXcmWeightConfig` (r:1 w:0)
	/// Proof: `XcmCoreBuyer::RelayXcmWeightConfig` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ServicesPayment::MaxCorePrice` (r:1 w:0)
	/// Proof: `ServicesPayment::MaxCorePrice` (`max_values`: None, `max_size`: Some(36), added: 2511, mode: `MaxEncodedLen`)
	/// Storage: `XcmCoreBuyer::RelayChain` (r:1 w:0)
	/// Proof: `XcmCoreBuyer::RelayChain` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::QueryCounter` (r:1 w:1)
	/// Proof: `PolkadotXcm::QueryCounter` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ParachainSystem::UpwardDeliveryFeeFactor` (r:1 w:0)
	/// Proof: `ParachainSystem::UpwardDeliveryFeeFactor` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::SupportedVersion` (r:1 w:0)
	/// Proof: `PolkadotXcm::SupportedVersion` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::VersionDiscoveryQueue` (r:1 w:1)
	/// Proof: `PolkadotXcm::VersionDiscoveryQueue` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::SafeXcmVersion` (r:1 w:0)
	/// Proof: `PolkadotXcm::SafeXcmVersion` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ParachainSystem::HostConfiguration` (r:1 w:0)
	/// Proof: `ParachainSystem::HostConfiguration` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ParachainSystem::PendingUpwardMessages` (r:1 w:1)
	/// Proof: `ParachainSystem::PendingUpwardMessages` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::QueryIdToParaId` (r:0 w:1)
	/// Proof: `XcmCoreBuyer::QueryIdToParaId` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::Queries` (r:0 w:1)
	/// Proof: `PolkadotXcm::Queries` (`max_values`: None, `max_size`: None, mode: `Measured`)
	fn buy_core() -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `1534`
		//  Estimated: `4999`
		// Minimum execution time: 46_000_000 picoseconds.
		Weight::from_parts(47_000_000, 4999)
			.saturating_add(T::DbWeight::get().reads(15_u64))
			.saturating_add(T::DbWeight::get().writes(7_u64))
	}
	/// Storage: `XcmCoreBuyer::InFlightOrders` (r:1 w:1)
	/// Proof: `XcmCoreBuyer::InFlightOrders` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::PendingBlocks` (r:1 w:0)
	/// Proof: `XcmCoreBuyer::PendingBlocks` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `Registrar::ParathreadParams` (r:1 w:0)
	/// Proof: `Registrar::ParathreadParams` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `AuthorNoting::LatestAuthor` (r:1 w:0)
	/// Proof: `AuthorNoting::LatestAuthor` (`max_values`: None, `max_size`: Some(64), added: 2539, mode: `MaxEncodedLen`)
	/// Storage: `XcmCoreBuyer::RelayXcmWeightConfig` (r:1 w:0)
	/// Proof: `XcmCoreBuyer::RelayXcmWeightConfig` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ServicesPayment::MaxCorePrice` (r:1 w:0)
	/// Proof: `ServicesPayment::MaxCorePrice` (`max_values`: None, `max_size`: Some(36), added: 2511, mode: `MaxEncodedLen`)
	/// Storage: `XcmCoreBuyer::RelayChain` (r:1 w:0)
	/// Proof: `XcmCoreBuyer::RelayChain` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::QueryCounter` (r:1 w:1)
	/// Proof: `PolkadotXcm::QueryCounter` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ParachainSystem::UpwardDeliveryFeeFactor` (r:1 w:0)
	/// Proof: `ParachainSystem::UpwardDeliveryFeeFactor` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::SupportedVersion` (r:1 w:0)
	/// Proof: `PolkadotXcm::SupportedVersion` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::VersionDiscoveryQueue` (r:1 w:1)
	/// Proof: `PolkadotXcm::VersionDiscoveryQueue` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::SafeXcmVersion` (r:1 w:0)
	/// Proof: `PolkadotXcm::SafeXcmVersion` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ParachainSystem::HostConfiguration` (r:1 w:0)
	/// Proof: `ParachainSystem::HostConfiguration` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ParachainSystem::PendingUpwardMessages` (r:1 w:1)
	/// Proof: `ParachainSystem::PendingUpwardMessages` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::QueryIdToParaId` (r:0 w:1)
	/// Proof: `XcmCoreBuyer::QueryIdToParaId` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::Queries` (r:0 w:1)
	/// Proof: `PolkadotXcm::Queries` (`max_values`: None, `max_size`: None, mode: `Measured`)
	fn force_buy_core() -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `1534`
		//  Estimated: `4999`
		// Minimum execution time: 44_000_000 picoseconds.
		Weight::from_parts(45_000_000, 4999)
			.saturating_add(T::DbWeight::get().reads(14_u64))
			.saturating_add(T::DbWeight::get().writes(6_u64))
	}
	/// Storage: `XcmCoreBuyer::QueryIdToParaId` (r:1 w:1)
	/// Proof: `XcmCoreBuyer::QueryIdToParaId` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::PendingBlocks` (r:0 w:1)
	/// Proof: `XcmCoreBuyer::PendingBlocks` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::InFlightOrders` (r:0 w:1)
	/// Proof: `XcmCoreBuyer::InFlightOrders` (`max_values`: None, `max_size`: None, mode: `Measured`)
	fn query_response() -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `1221`
		//  Estimated: `4686`
		// Minimum execution time: 15_000_000 picoseconds.
		Weight::from_parts(15_000_000, 4686)
			.saturating_add(T::DbWeight::get().reads(1_u64))
			.saturating_add(T::DbWeight::get().writes(3_u64))
	}
	/// Storage: `XcmCoreBuyer::InFlightOrders` (r:1000 w:1000)
	/// Proof: `XcmCoreBuyer::InFlightOrders` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::QueryIdToParaId` (r:0 w:1000)
	/// Proof: `XcmCoreBuyer::QueryIdToParaId` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// The range of component `x` is `[1, 1000]`.
	fn clean_up_expired_in_flight_orders(x: u32, ) -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `205 + x * (36 ±0)`
		//  Estimated: `3684 + x * (2512 ±0)`
		// Minimum execution time: 13_000_000 picoseconds.
		Weight::from_parts(13_000_000, 3684)
			// Standard Error: 11_138
			.saturating_add(Weight::from_parts(4_263_561, 0).saturating_mul(x.into()))
			.saturating_add(T::DbWeight::get().reads(1_u64))
			.saturating_add(T::DbWeight::get().reads((1_u64).saturating_mul(x.into())))
			.saturating_add(T::DbWeight::get().writes(2_u64))
			.saturating_add(T::DbWeight::get().writes((2_u64).saturating_mul(x.into())))
			.saturating_add(Weight::from_parts(0, 2512).saturating_mul(x.into()))
	}
	/// Storage: `XcmCoreBuyer::PendingBlocks` (r:1000 w:1000)
	/// Proof: `XcmCoreBuyer::PendingBlocks` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// The range of component `x` is `[1, 1000]`.
	fn clean_up_expired_pending_blocks(x: u32, ) -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `147 + x * (23 ±0)`
		//  Estimated: `3627 + x * (2499 ±0)`
		// Minimum execution time: 11_000_000 picoseconds.
		Weight::from_parts(7_280_568, 3627)
			// Standard Error: 5_885
			.saturating_add(Weight::from_parts(2_701_842, 0).saturating_mul(x.into()))
			.saturating_add(T::DbWeight::get().reads(1_u64))
			.saturating_add(T::DbWeight::get().reads((1_u64).saturating_mul(x.into())))
			.saturating_add(T::DbWeight::get().writes(1_u64))
			.saturating_add(T::DbWeight::get().writes((1_u64).saturating_mul(x.into())))
			.saturating_add(Weight::from_parts(0, 2499).saturating_mul(x.into()))
	}
	/// Storage: `XcmCoreBuyer::RelayXcmWeightConfig` (r:0 w:1)
	/// Proof: `XcmCoreBuyer::RelayXcmWeightConfig` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	fn set_relay_xcm_weight_config() -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `0`
		//  Estimated: `0`
		// Minimum execution time: 2_000_000 picoseconds.
		Weight::from_parts(2_000_000, 0)
			.saturating_add(T::DbWeight::get().writes(1_u64))
	}
	/// Storage: `XcmCoreBuyer::RelayChain` (r:0 w:1)
	/// Proof: `XcmCoreBuyer::RelayChain` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	fn set_relay_chain() -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `0`
		//  Estimated: `0`
		// Minimum execution time: 2_000_000 picoseconds.
		Weight::from_parts(2_000_000, 0)
			.saturating_add(T::DbWeight::get().writes(1_u64))
	}
}

// For backwards compatibility and tests
impl WeightInfo for () {
	/// Storage: `XcmCoreBuyer::CollatorSignatureNonce` (r:1 w:1)
	/// Proof: `XcmCoreBuyer::CollatorSignatureNonce` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::InFlightOrders` (r:1 w:1)
	/// Proof: `XcmCoreBuyer::InFlightOrders` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::PendingBlocks` (r:1 w:0)
	/// Proof: `XcmCoreBuyer::PendingBlocks` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `Registrar::ParathreadParams` (r:1 w:0)
	/// Proof: `Registrar::ParathreadParams` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `AuthorNoting::LatestAuthor` (r:1 w:0)
	/// Proof: `AuthorNoting::LatestAuthor` (`max_values`: None, `max_size`: Some(64), added: 2539, mode: `MaxEncodedLen`)
	/// Storage: `XcmCoreBuyer::RelayXcmWeightConfig` (r:1 w:0)
	/// Proof: `XcmCoreBuyer::RelayXcmWeightConfig` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ServicesPayment::MaxCorePrice` (r:1 w:0)
	/// Proof: `ServicesPayment::MaxCorePrice` (`max_values`: None, `max_size`: Some(36), added: 2511, mode: `MaxEncodedLen`)
	/// Storage: `XcmCoreBuyer::RelayChain` (r:1 w:0)
	/// Proof: `XcmCoreBuyer::RelayChain` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::QueryCounter` (r:1 w:1)
	/// Proof: `PolkadotXcm::QueryCounter` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ParachainSystem::UpwardDeliveryFeeFactor` (r:1 w:0)
	/// Proof: `ParachainSystem::UpwardDeliveryFeeFactor` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::SupportedVersion` (r:1 w:0)
	/// Proof: `PolkadotXcm::SupportedVersion` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::VersionDiscoveryQueue` (r:1 w:1)
	/// Proof: `PolkadotXcm::VersionDiscoveryQueue` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::SafeXcmVersion` (r:1 w:0)
	/// Proof: `PolkadotXcm::SafeXcmVersion` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ParachainSystem::HostConfiguration` (r:1 w:0)
	/// Proof: `ParachainSystem::HostConfiguration` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ParachainSystem::PendingUpwardMessages` (r:1 w:1)
	/// Proof: `ParachainSystem::PendingUpwardMessages` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::QueryIdToParaId` (r:0 w:1)
	/// Proof: `XcmCoreBuyer::QueryIdToParaId` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::Queries` (r:0 w:1)
	/// Proof: `PolkadotXcm::Queries` (`max_values`: None, `max_size`: None, mode: `Measured`)
	fn buy_core() -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `1534`
		//  Estimated: `4999`
		// Minimum execution time: 46_000_000 picoseconds.
		Weight::from_parts(47_000_000, 4999)
			.saturating_add(RocksDbWeight::get().reads(15_u64))
			.saturating_add(RocksDbWeight::get().writes(7_u64))
	}
	/// Storage: `XcmCoreBuyer::InFlightOrders` (r:1 w:1)
	/// Proof: `XcmCoreBuyer::InFlightOrders` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::PendingBlocks` (r:1 w:0)
	/// Proof: `XcmCoreBuyer::PendingBlocks` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `Registrar::ParathreadParams` (r:1 w:0)
	/// Proof: `Registrar::ParathreadParams` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `AuthorNoting::LatestAuthor` (r:1 w:0)
	/// Proof: `AuthorNoting::LatestAuthor` (`max_values`: None, `max_size`: Some(64), added: 2539, mode: `MaxEncodedLen`)
	/// Storage: `XcmCoreBuyer::RelayXcmWeightConfig` (r:1 w:0)
	/// Proof: `XcmCoreBuyer::RelayXcmWeightConfig` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ServicesPayment::MaxCorePrice` (r:1 w:0)
	/// Proof: `ServicesPayment::MaxCorePrice` (`max_values`: None, `max_size`: Some(36), added: 2511, mode: `MaxEncodedLen`)
	/// Storage: `XcmCoreBuyer::RelayChain` (r:1 w:0)
	/// Proof: `XcmCoreBuyer::RelayChain` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::QueryCounter` (r:1 w:1)
	/// Proof: `PolkadotXcm::QueryCounter` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ParachainSystem::UpwardDeliveryFeeFactor` (r:1 w:0)
	/// Proof: `ParachainSystem::UpwardDeliveryFeeFactor` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::SupportedVersion` (r:1 w:0)
	/// Proof: `PolkadotXcm::SupportedVersion` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::VersionDiscoveryQueue` (r:1 w:1)
	/// Proof: `PolkadotXcm::VersionDiscoveryQueue` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::SafeXcmVersion` (r:1 w:0)
	/// Proof: `PolkadotXcm::SafeXcmVersion` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ParachainSystem::HostConfiguration` (r:1 w:0)
	/// Proof: `ParachainSystem::HostConfiguration` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `ParachainSystem::PendingUpwardMessages` (r:1 w:1)
	/// Proof: `ParachainSystem::PendingUpwardMessages` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::QueryIdToParaId` (r:0 w:1)
	/// Proof: `XcmCoreBuyer::QueryIdToParaId` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `PolkadotXcm::Queries` (r:0 w:1)
	/// Proof: `PolkadotXcm::Queries` (`max_values`: None, `max_size`: None, mode: `Measured`)
	fn force_buy_core() -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `1534`
		//  Estimated: `4999`
		// Minimum execution time: 44_000_000 picoseconds.
		Weight::from_parts(45_000_000, 4999)
			.saturating_add(RocksDbWeight::get().reads(14_u64))
			.saturating_add(RocksDbWeight::get().writes(6_u64))
	}
	/// Storage: `XcmCoreBuyer::QueryIdToParaId` (r:1 w:1)
	/// Proof: `XcmCoreBuyer::QueryIdToParaId` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::PendingBlocks` (r:0 w:1)
	/// Proof: `XcmCoreBuyer::PendingBlocks` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::InFlightOrders` (r:0 w:1)
	/// Proof: `XcmCoreBuyer::InFlightOrders` (`max_values`: None, `max_size`: None, mode: `Measured`)
	fn query_response() -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `1221`
		//  Estimated: `4686`
		// Minimum execution time: 15_000_000 picoseconds.
		Weight::from_parts(15_000_000, 4686)
			.saturating_add(RocksDbWeight::get().reads(1_u64))
			.saturating_add(RocksDbWeight::get().writes(3_u64))
	}
	/// Storage: `XcmCoreBuyer::InFlightOrders` (r:1000 w:1000)
	/// Proof: `XcmCoreBuyer::InFlightOrders` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// Storage: `XcmCoreBuyer::QueryIdToParaId` (r:0 w:1000)
	/// Proof: `XcmCoreBuyer::QueryIdToParaId` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// The range of component `x` is `[1, 1000]`.
	fn clean_up_expired_in_flight_orders(x: u32, ) -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `205 + x * (36 ±0)`
		//  Estimated: `3684 + x * (2512 ±0)`
		// Minimum execution time: 13_000_000 picoseconds.
		Weight::from_parts(13_000_000, 3684)
			// Standard Error: 11_138
			.saturating_add(Weight::from_parts(4_263_561, 0).saturating_mul(x.into()))
			.saturating_add(RocksDbWeight::get().reads(1_u64))
			.saturating_add(RocksDbWeight::get().reads((1_u64).saturating_mul(x.into())))
			.saturating_add(RocksDbWeight::get().writes(2_u64))
			.saturating_add(RocksDbWeight::get().writes((2_u64).saturating_mul(x.into())))
			.saturating_add(Weight::from_parts(0, 2512).saturating_mul(x.into()))
	}
	/// Storage: `XcmCoreBuyer::PendingBlocks` (r:1000 w:1000)
	/// Proof: `XcmCoreBuyer::PendingBlocks` (`max_values`: None, `max_size`: None, mode: `Measured`)
	/// The range of component `x` is `[1, 1000]`.
	fn clean_up_expired_pending_blocks(x: u32, ) -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `147 + x * (23 ±0)`
		//  Estimated: `3627 + x * (2499 ±0)`
		// Minimum execution time: 11_000_000 picoseconds.
		Weight::from_parts(7_280_568, 3627)
			// Standard Error: 5_885
			.saturating_add(Weight::from_parts(2_701_842, 0).saturating_mul(x.into()))
			.saturating_add(RocksDbWeight::get().reads(1_u64))
			.saturating_add(RocksDbWeight::get().reads((1_u64).saturating_mul(x.into())))
			.saturating_add(RocksDbWeight::get().writes(1_u64))
			.saturating_add(RocksDbWeight::get().writes((1_u64).saturating_mul(x.into())))
			.saturating_add(Weight::from_parts(0, 2499).saturating_mul(x.into()))
	}
	/// Storage: `XcmCoreBuyer::RelayXcmWeightConfig` (r:0 w:1)
	/// Proof: `XcmCoreBuyer::RelayXcmWeightConfig` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	fn set_relay_xcm_weight_config() -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `0`
		//  Estimated: `0`
		// Minimum execution time: 2_000_000 picoseconds.
		Weight::from_parts(2_000_000, 0)
			.saturating_add(RocksDbWeight::get().writes(1_u64))
	}
	/// Storage: `XcmCoreBuyer::RelayChain` (r:0 w:1)
	/// Proof: `XcmCoreBuyer::RelayChain` (`max_values`: Some(1), `max_size`: None, mode: `Measured`)
	fn set_relay_chain() -> Weight {
		// Proof Size summary in bytes:
		//  Measured:  `0`
		//  Estimated: `0`
		// Minimum execution time: 2_000_000 picoseconds.
		Weight::from_parts(2_000_000, 0)
			.saturating_add(RocksDbWeight::get().writes(1_u64))
	}
}
