// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.Api.Legacy.Requests
{
    public class OsuLegacyUserRequest : OsuLegacyUserBasedRequest
    {
        private uint? _dateRange;

        public override string Target => "user";

        public OsuLegacyUserRequest(string userIdentifier)
            : base(userIdentifier)
        {
        }

        [QueryParameter("event_days")]
        public uint EventDateRange
        {
            get => _dateRange ??= 7;
            set
            {
                if (value > 31 || value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(EventDateRange), "Must be in the range 1-31");
                }

                _dateRange = value;
            }
        }
    }
}
