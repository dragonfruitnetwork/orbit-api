// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuBeatmapInfoRequest : OrbitApiRequest
    {
        protected override string Route => $"/beatmaps/{MapId}";

        /// <summary>
        /// Create a request to get the info for a specific beatmap
        /// </summary>
        public OsuBeatmapInfoRequest(uint mapId)
        {
            MapId = mapId;
        }

        public uint MapId { get; set; }
    }
}
