// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.User.Entities;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ranking.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuCountryStatistics
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("active_users")]
        public uint ActiveUsers { get; set; }

        [JsonProperty("play_count")]
        public ulong PlayCount { get; set; }

        [JsonProperty("ranked_score")]
        public ulong RankedScore { get; set; }

        [JsonProperty("performance")]
        public ulong Performance { get; set; }

        [JsonProperty("country")]
        public OsuUserCountry Country { get; set; }
    }
}
