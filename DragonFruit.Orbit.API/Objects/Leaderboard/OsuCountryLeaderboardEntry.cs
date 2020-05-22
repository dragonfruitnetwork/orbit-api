// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.User;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Leaderboard
{
    public class OsuCountryLeaderboardEntry
    {
        [JsonProperty("code")]
        public string CountryCode { get; set; }

        [JsonProperty("active_users")]
        public ulong ActiveUsers { get; set; }

        [JsonProperty("play_count")]
        public ulong TotalPlayCount { get; set; }

        [JsonProperty("performance")]
        public ulong TotalPP { get; set; }

        [JsonProperty("country")]
        public Country CountryInfo { get; set; }
    }
}
