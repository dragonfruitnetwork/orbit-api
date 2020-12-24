// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Legacy.Enums;

namespace DragonFruit.Orbit.Api.Legacy.Requests
{
    public class OsuLegacyScoresRequest : OsuLegacyUserBasedRequest
    {
        private uint? _limit;

        public override string Target => "scores";

        [QueryParameter("b")]
        public uint BeatmapId { get; set; }

        [QueryParameter("mods", EnumHandlingMode.Numeric)]
        public LegacyMods? Mods { get; set; }

        [QueryParameter("limit")]
        public virtual uint? Limit
        {
            get => _limit;
            set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(Limit), "Limit must be in the range 1-100");
                }

                _limit = value;
            }
        }
    }
}
