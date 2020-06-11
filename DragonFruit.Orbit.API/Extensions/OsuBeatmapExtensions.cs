// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Beatmaps;
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
    }
}
