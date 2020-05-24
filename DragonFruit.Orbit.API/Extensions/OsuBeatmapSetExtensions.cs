// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Beatmaps;
using DragonFruit.Orbit.API.Requests;

namespace DragonFruit.Orbit.API.Extensions
{
    public static class OsuBeatmapSetExtensions
    {
        /// <summary>
        /// Get the <see cref="OsuBeatmapSetInfo"/> using the id of the collection (collection id)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="beatmapsetId">The id of the mapset/collection</param>
        public static OsuBeatmapSetInfo GetBeatmapSetInfo(this OrbitClient client, uint beatmapsetId)
        {
            var request = new OsuBeatmapsetInfoRequest(beatmapsetId);
            return client.Perform<OsuBeatmapSetInfo>(request);
        }

        /// <summary>
        /// Get the <see cref="OsuBeatmapSetInfo"/> using one of the ids of a map contained in the set (map id)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="childMapId">An id of a map in the mapset/collection</param>
        public static OsuBeatmapSetInfo GetBeatmapSetInfoByMapId(this OrbitClient client, uint childMapId)
        {
            var request = new OsuBeatmapsetLookupRequest(childMapId);
            return client.Perform<OsuBeatmapSetInfo>(request);
        }
    }
}
