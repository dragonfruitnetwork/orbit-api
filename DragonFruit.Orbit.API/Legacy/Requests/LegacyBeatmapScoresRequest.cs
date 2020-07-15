// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Objects.Enums;

namespace DragonFruit.Orbit.API.Legacy.Requests
{
    public class LegacyBeatmapScoresRequest : LegacyEnumerableResponseRequest
    {
        public override string Path => "https://osu.ppy.sh/api/get_scores";

        public LegacyBeatmapScoresRequest(uint beatmapId)
        {
            BeatmapId = beatmapId;
        }

        public LegacyBeatmapScoresRequest(uint beatmapId, OsuMods mods)
            : this(beatmapId)
        {
            Mods = mods;
        }

        [QueryParameter("b")]
        public uint BeatmapId { get; set; }

        public OsuMods Mods { get; set; } = OsuMods.None;

        [QueryParameter("mods")]
        private uint ModsQuery => (uint)Mods;
    }
}
