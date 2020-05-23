// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuBeatmapsetLookupRequest : OrbitApiRequest
    {
        public override string Path => $"https://osu.ppy.sh/api/v2/beatmapsets/lookup";

        public OsuBeatmapsetLookupRequest(uint mapId)
        {
            Id = mapId;
        }

        [QueryParameter("beatmap_id")]
        public uint Id { get; set; }
    }
}
