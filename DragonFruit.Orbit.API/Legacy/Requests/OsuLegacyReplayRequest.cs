// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Legacy.Enums;

namespace DragonFruit.Orbit.Api.Legacy.Requests
{
    public class OsuLegacyReplayRequest : OsuLegacyBeatmapScoresRequest
    {
        public override string Target => "replay";

        // this is the same as a legacy score request but has no limit
        public override uint? Limit => null;

        [QueryParameter("s")]
        public ulong? ScoreId { get; set; }

        [QueryParameter("mods", EnumHandlingMode.Numeric)]
        public LegacyMods? Mods { get; set; }
    }
}
