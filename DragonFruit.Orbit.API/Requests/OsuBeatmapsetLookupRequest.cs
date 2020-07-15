// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuBeatmapsetLookupRequest : OrbitApiRequest
    {
        protected override string Route => "/beatmapsets/lookup";

        /// <summary>
        /// Get a beatmapsets' info based on the id of a containing map
        /// </summary>
        public OsuBeatmapsetLookupRequest(uint mapId)
        {
            Id = mapId;
        }

        [QueryParameter("beatmap_id")]
        public uint? Id { get; set; }
    }
}
