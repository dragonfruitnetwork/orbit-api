// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.Api.Legacy.Requests
{
    public class OsuLegacyRecentScoresRequest : OsuLegacyUserBasedRequest
    {
        private uint? _limit;

        public override string Target => "user_recent";

        [QueryParameter("limit")]
        public uint? Limit
        {
            get => _limit;
            set
            {
                if (value <= 0 || value > 50)
                {
                    throw new ArgumentOutOfRangeException(nameof(Limit), "Limit must be in range 1-50");
                }
            }
        }
    }
}
