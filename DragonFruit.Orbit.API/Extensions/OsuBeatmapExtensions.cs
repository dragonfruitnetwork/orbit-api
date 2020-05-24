// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Beatmaps;
using DragonFruit.Orbit.API.Requests;

namespace DragonFruit.Orbit.API.Extensions
{
    public static class OsuBeatmapExtensions
    {
        public static OsuBeatmapInfo GetBeatmapInfoById(this OrbitClient client, uint beatmapId)
        {
            var request = new OsuBeatmapInfoRequest(beatmapId);
            return client.Perform<OsuBeatmapInfo>(request);
        }

        public static OsuBeatmapInfo GetBeatmapInfoByFilename(this OrbitClient client, string filename)
        {
            var request = new OsuBeatmapLookupRequest { Filename = filename };
            return client.Perform<OsuBeatmapInfo>(request);
        }

        public static OsuBeatmapInfo GetBeatmapInfoByHash(this OrbitClient client, string md5)
        {
            var request = new OsuBeatmapLookupRequest { Md5Hash = md5 };
            return client.Perform<OsuBeatmapInfo>(request);
        }
    }
}
