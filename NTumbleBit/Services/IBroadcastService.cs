﻿using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTumbleBit.Services
{
	public interface IBroadcastService
    {
		bool Broadcast(Transaction tx);
		Transaction GetKnownTransaction(uint256 txId);
		Transaction[] TryBroadcast(ref uint256[] knownBroadcasted);
		Transaction[] TryBroadcast();

	}
}
