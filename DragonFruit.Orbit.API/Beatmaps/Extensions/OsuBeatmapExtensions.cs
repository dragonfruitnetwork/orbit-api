// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Orbit.Api.Beatmaps.Entities;
using DragonFruit.Orbit.Api.Beatmaps.Enums;
using DragonFruit.Orbit.Api.Beatmaps.Requests;

namespace DragonFruit.Orbit.Api.Beatmaps.Extensions
{
    public static class OsuBeatmapExtensions
    {
        /// <summary>
        /// Get the top 50 scores for a beatmap
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mapId">The id of the map</param>
        /// <param name="mode">The mode to return. Defaults to the map's original mode</param>
        /// <param name="type">The <see cref="BeatmapLeaderboardType"/>. Global by default and will fail otherwise if the user is not a supporter</param>
        /// <param name="mods">Array of mods to filter by. Probably need to be a supporter to send these</param>
        public static OsuBeamapScores GetScores<T>(this T client, uint mapId, GameMode? mode = null, BeatmapLeaderboardType? type = null, IEnumerable<string> mods = null) where T : OrbitClient
        {
            var request = new OsuBeatmapScoresRequest(mapId)
            {
                Mode = mode,
                Mods = mods,
                Type = type
            };

            return client.Perform<OsuBeamapScores>(request);
        }

        /// <summary>
        /// Get a beatmap's metadata by its online id
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mapId">The id of the map</param>
        public static OsuBeatmap GetBeatmap<T>(this T client, uint mapId) where T : OrbitClient
        {
            var request = new OsuBeatmapRequest
            {
                BeatmapId = mapId
            };

            return client.Perform<OsuBeatmap>(request);
        }

        /// <summary>
        /// Get a beatmap's metadata by its MD5 hash
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mapHash">The MD5 hash of the map</param>
        public static OsuBeatmap GetBeatmapByHash<T>(this T client, string mapHash) where T : OrbitClient
        {
            var request = new OsuBeatmapRequest
            {
                Hash = mapHash
            };

            return client.Perform<OsuBeatmap>(request);
        }

        /// <summary>
        /// Get a beatmap's metadata by its original filename
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="fileName">The original, unedited name of the map</param>
        public static OsuBeatmap GetBeatmapByFilename<T>(this T client, string fileName) where T : OrbitClient
        {
            var request = new OsuBeatmapRequest
            {
                Filename = fileName
            };

            return client.Perform<OsuBeatmap>(request);
        }
    }
}
