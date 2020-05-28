// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using System.Linq;
using DragonFruit.Orbit.API.Objects.Beatmaps;
using DragonFruit.Orbit.API.Objects.User;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Spotlights
{
    public class OsuSpotlightsLeaderboardContainer
    {
        [JsonProperty("ranking")]
        public IOrderedEnumerable<OsuUserStats> UserRanking { get; set; }

        [JsonProperty("spotlight")]
        public OsuSpotlightEntry Info { get; set; }

        [JsonProperty("beatmapsets")]
        public IEnumerable<OsuBeatmapsetInfo> BeatmapSets { get; set; }
    }
}
