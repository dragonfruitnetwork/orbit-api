// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Orbit.API.Objects.Beatmaps;
using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Requests;

namespace DragonFruit.Orbit.API.Extensions
{
    public static class OsuBeatmapSetExtensions
    {
        /// <summary>
        /// Get the <see cref="OsuBeatmapsetInfo"/> using the id of the collection (collection id)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="beatmapsetId">The id of the mapset/collection</param>
        public static OsuBeatmapsetInfo GetBeatmapSetInfo(this OrbitClient client, uint beatmapsetId)
        {
            var request = new OsuBeatmapsetInfoRequest(beatmapsetId);
            return client.Perform<OsuBeatmapsetInfo>(request);
        }

        /// <summary>
        /// Get the <see cref="OsuBeatmapsetInfo"/> using one of the ids of a map contained in the set (map id)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="childMapId">An id of a map in the mapset/collection</param>
        public static OsuBeatmapsetInfo GetBeatmapSetInfoByMapId(this OrbitClient client, uint childMapId)
        {
            var request = new OsuBeatmapsetLookupRequest(childMapId);
            return client.Perform<OsuBeatmapsetInfo>(request);
        }

        /// <summary>
        /// Search for ranked beatmaps for all game modes
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="query">The search query</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="OsuBeatmapInfo"/>s matching the search criteria</returns>
        public static IEnumerable<OsuBeatmapsetInfo> SearchForBeatmapsets(this OrbitClient client, string query)
        {
            var request = new OsuBeatmapsetSearchRequest(query);
            return client.Perform<OsuBeatmapsetSearchResultContainer>(request).Beatmapsets;
        }

        /// <summary>
        /// Search for beatmaps for a specific mode and criteria
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="query">The search query</param>
        /// <param name="mode">The game mode to return maps for</param>
        /// <param name="sortCriteria">The sort filters to apply to the search</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="OsuBeatmapInfo"/>s matching the search criteria</returns>
        public static IEnumerable<OsuBeatmapsetInfo> SearchForBeatmapsets(this OrbitClient client, string query, GameMode mode, OsuBeatmapsetSearchSortCriteria sortCriteria)
        {
            var request = new OsuBeatmapsetSearchRequest
            {
                Query = query,
                Mode = mode,
                SortCriteria = sortCriteria
            };

            return client.Perform<OsuBeatmapsetSearchResultContainer>(request).Beatmapsets;
        }

        /// <summary>
        /// Search for beatmaps fulfilling a specific criteria
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="query">The search query</param>
        /// <param name="sortCriteria">The sort filters to apply to the search</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="OsuBeatmapInfo"/>s matching the search criteria</returns>
        public static IEnumerable<OsuBeatmapsetInfo> SearchForBeatmapsets(this OrbitClient client, string query, OsuBeatmapsetSearchSortCriteria sortCriteria)
        {
            var request = new OsuBeatmapsetSearchRequest
            {
                Query = query,
                SortCriteria = sortCriteria
            };

            return client.Perform<OsuBeatmapsetSearchResultContainer>(request).Beatmapsets;
        }
    }
}
