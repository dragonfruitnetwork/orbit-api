// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using DragonFruit.Orbit.Api.Beatmaps.Entities;
using DragonFruit.Orbit.Api.Interfaces;
using DragonFruit.Orbit.Api.User.Entities;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ranking.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuLeaderboard<T> : IPaginatedByCursor
    {
        [JsonProperty("total")]
        public int TotalEntries { get; set; }

        [JsonProperty("ranking")]
        public IEnumerable<T> Ranking { get; set; }

        [CanBeNull]
        [JsonProperty("spotlight")]
        public OsuSpotlightEvent Spotlight { get; set; }

        [CanBeNull]
        [JsonProperty("beatmapsets")]
        public IEnumerable<OsuBeatmapset> SpotlightMapsets { get; set; }

        [JsonProperty("cursor")]
        public IReadOnlyDictionary<string, string> Cursor { get; set; }
    }

    public class OsuCountryLeaderboard : OsuLeaderboard<OsuCountryStatistics>
    {
    }

    public class OsuUserLeaderboard : OsuLeaderboard<OsuUserStatistics>
    {
    }
}
