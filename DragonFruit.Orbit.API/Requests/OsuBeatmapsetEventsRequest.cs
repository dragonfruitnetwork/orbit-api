// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuBeatmapsetEventsRequest : OrbitPaginatedRequest
    {
        protected override string Route => "/beatmapsets/events";
        protected override bool UsesOffset => true;

        /// <summary>
        /// Get the most recent beatmapset modding events
        /// </summary>
        public OsuBeatmapsetEventsRequest()
        {
        }

        /// <summary>
        /// Get a specific page of beatmapset modding events
        /// </summary>
        public OsuBeatmapsetEventsRequest(uint page)
        {
            Page = page;
        }
    }
}
