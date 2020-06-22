// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapScoreContainer
    {
        [JsonProperty(@"scores")]
        public IEnumerable<OsuBeatmapScoreInfo> Scores { get; set; }

        [JsonProperty(@"userScore")]
        public OsuBeatmapUserTopScore UserScore { get; set; }
    }
}
