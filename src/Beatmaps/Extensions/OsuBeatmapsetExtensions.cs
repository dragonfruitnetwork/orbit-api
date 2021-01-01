// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Beatmaps.Entities;
using DragonFruit.Orbit.Api.Beatmaps.Enums;
using DragonFruit.Orbit.Api.Beatmaps.Requests;
using DragonFruit.Orbit.Api.User.Enums;

namespace DragonFruit.Orbit.Api.Beatmaps.Extensions
{
    public static class OsuBeatmapsetExtensions
    {
        /// <summary>
        /// Get a beatmapset's metadata/info from its id
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="setId">The id of the set</param>
        public static OsuBeatmapset GetBeatmapset<T>(this T client, uint setId) where T : OrbitClient
        {
            var request = new OsuBeatmapsetRequest
            {
                Id = setId
            };

            return client.Perform<OsuBeatmapset>(request);
        }

        /// <summary>
        /// Get a beatmapset's metadata/info from a child map's id
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="childMapId">The id of a map in the set</param>
        public static OsuBeatmapset GetBeatmapsetFromMap<T>(this T client, uint childMapId) where T : OrbitClient
        {
            var request = new OsuBeatmapsetRequest
            {
                ChildMapId = childMapId
            };

            return client.Perform<OsuBeatmapset>(request);
        }

        /// <summary>
        /// Perform a search for a beatmapset
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="query">The search query</param>
        /// <param name="mode">Mode to filter results by</param>
        /// <param name="status">Authenticated user's play status</param>
        /// <param name="category"><see cref="BeatmapsetCategory"/> to filter results by</param>
        /// <param name="criteria"><see cref="BeatmapsetSearchCriteria"/> to order results by</param>
        /// <param name="extraFlags">A set of flags to further filter by</param>
        /// <param name="genre">Optional genre to filter by</param>
        /// <param name="language">Optional language to filter by</param>
        /// <param name="rankFilter">Collection of ranks to filter by</param>
        /// <param name="descending">Whether to return in ascending or descending order</param>
        /// <param name="last">The last set of responses. Used to get the next "page"</param>
        public static OsuBeatmapsetSearch PerformBeatmapsetSearch<T>(this T client, string query, GameMode? mode = null, BeatmapsetPlayStatus? status = null, BeatmapsetCategory? category = null,
                                                                     BeatmapsetSearchCriteria? criteria = null, BeatmapSearchFlags? extraFlags = null, BeatmapsetGenre? genre = null,
                                                                     BeatmapsetLanguage? language = null, ScoreGrade? rankFilter = null, bool descending = true, OsuBeatmapsetSearch last = null)
            where T : OrbitClient
        {
            var request = new OsuBeatmapsetSearchRequest
            {
                Query = query,
                Mode = mode,
                Status = status,
                Category = category,
                Criteria = criteria,
                ExtraFlags = extraFlags,
                Genre = genre,
                Language = language,
                Descending = descending,

                Cursor = last?.Cursor
            };

            return client.Perform<OsuBeatmapsetSearch>(request);
        }
    }
}
