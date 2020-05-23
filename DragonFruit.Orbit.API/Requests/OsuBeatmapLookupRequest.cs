// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuBeatmapLookupRequest : OrbitApiRequest
    {
        public override string Path => "https://osu.ppy.sh/api/v2/beatmaps/lookup";

        [QueryParameter("id")]
        public uint? MapId { get; set; }

        [QueryParameter("checksum")]
        public string? Md5Hash { get; set; }

        [QueryParameter("filename")]
        public string? Filename { get; set; }
    }
}
