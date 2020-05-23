// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.API.Requests.Beatmaps
{
    public class OsuBeatmapsetInfoRequest : OrbitApiRequest
    {
        public override string Path => $"https://osu.ppy.sh/api/v2/beatmapsets/{MapsetId}";

        public OsuBeatmapsetInfoRequest(uint mapsetId)
        {
            MapsetId = mapsetId;
        }

        public uint MapsetId { get; set; }
    }
}
