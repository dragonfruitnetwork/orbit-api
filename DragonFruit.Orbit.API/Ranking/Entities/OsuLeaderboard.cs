// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Orbit.Api.Beatmaps.Entities;
using DragonFruit.Orbit.Api.Interfaces;
using DragonFruit.Orbit.Api.User.Entities;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ranking.Entities
{
    public class OsuLeaderboard : IPaginatedByCursor
    {
        [JsonProperty("total")]
        public uint TotalEntries { get; set; }

        [JsonProperty("ranking")]
        public IEnumerable<OsuUserStatistics> Ranking { get; set; }

        [CanBeNull]
        [JsonProperty("spotlight")]
        public OsuSpotlightEvent Spotlight { get; set; }

        [CanBeNull]
        [JsonProperty("beatmapsets")]
        public IEnumerable<OsuBeatmapset> SpotlightMapsets { get; set; }

        [JsonProperty("cursor")]
        public IReadOnlyDictionary<string, string> Cursor { get; set; }
    }
}
