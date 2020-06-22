// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Beatmaps;
using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Requests;

namespace DragonFruit.Orbit.API.Extensions
{
    public static class OsuBeatmapExtensions
    {
        /// <summary>
        /// Get a single beatmap's info by its online ID
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="beatmapId">The id of the beatmap (not the set)</param>
        public static OsuBeatmapInfo GetBeatmapInfoById(this OrbitClient client, uint beatmapId)
        {
            var request = new OsuBeatmapInfoRequest(beatmapId);
            return client.Perform<OsuBeatmapInfo>(request);
        }

        /// <summary>
        /// Get a single beatmap's info by its filename
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="filename">The name of the beatmap (including ".osu" extension)</param>
        public static OsuBeatmapInfo GetBeatmapInfoByFilename(this OrbitClient client, string filename)
        {
            var request = new OsuBeatmapLookupRequest { Filename = filename };
            return client.Perform<OsuBeatmapInfo>(request);
        }

        /// <summary>
        /// Get a single map from its hash
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="md5">The MD5 hash of the beatmap file</param>
        public static OsuBeatmapInfo GetBeatmapInfoByHash(this OrbitClient client, string md5)
        {
            var request = new OsuBeatmapLookupRequest { Md5Hash = md5 };
            return client.Perform<OsuBeatmapInfo>(request);
        }

        /// <summary>
        /// Get the leaderboard for a map and mode. Supporters can also access country and friend leaderboards
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mapId">The ID of the beatmap</param>
        /// <param name="mode">The name of the mode</param>
        /// <param name="scoreboardType">
        /// The type of leaderboard to return.
        /// Should be set to <see cref="BeatmapLeaderboardScope.Global"/> unless the user is a supporter
        /// </param>
        public static OsuBeatmapScoreContainer GetBeatmapScores(this OrbitClient client, uint mapId, GameMode mode, BeatmapLeaderboardScope scoreboardType)
        {
            var request = new OsuBeatmapScoresRequest(mapId, mode, scoreboardType);
            return client.Perform<OsuBeatmapScoreContainer>(request);
        }
    }
}
