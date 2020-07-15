// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuBeatmapsetInfoRequest : OrbitApiRequest
    {
        protected override string Route => $"/beatmapsets/{MapsetId}";

        /// <summary>
        /// Gets a beatmapset and the maps contained inside based on the set's id
        /// </summary>
        /// <param name="mapsetId"></param>
        public OsuBeatmapsetInfoRequest(uint mapsetId)
        {
            MapsetId = mapsetId;
        }

        public uint MapsetId { get; set; }
    }
}
