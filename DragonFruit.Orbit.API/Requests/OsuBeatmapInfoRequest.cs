// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuBeatmapInfoRequest : OrbitApiRequest
    {
        protected override string Route => $"/beatmaps/{MapId}";

        public OsuBeatmapInfoRequest(uint mapId)
        {
            MapId = mapId;
        }

        public uint MapId { get; set; }
    }
}
