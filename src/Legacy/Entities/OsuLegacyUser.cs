// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Legacy.Entities
{
    [Serializable]
    public class OsuLegacyUser
    {
        [JsonProperty("user_id")]
        public uint UserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("join_date")]
        public DateTime JoinDateUtc { get; set; }

        [JsonProperty("count300")]
        public uint Count300 { get; set; }

        [JsonProperty("count100")]
        public uint Count100 { get; set; }

        [JsonProperty("count50")]
        public uint Count50 { get; set; }

        [JsonProperty("playcount")]
        public uint PlayCount { get; set; }

        [JsonProperty("ranked_score")]
        public ulong RankedScore { get; set; }

        [JsonProperty("total_score")]
        public ulong TotalScore { get; set; }

        [JsonProperty("pp_raw")]
        public float PP { get; set; }

        [JsonProperty("pp_rank")]
        public int? GlobalRank { get; set; }

        [JsonProperty("pp_country_rank")]
        public int? CountryRank { get; set; }

        [JsonProperty("level")]
        public float Level { get; set; }

        [JsonProperty("accuracy")]
        public float Accuracy { get; set; }

        [JsonProperty("count_rank_ss")]
        public int CountRankSS { get; set; }

        [JsonProperty("count_rank_ssh")]
        public int CountRankSSPlus { get; set; }

        [JsonProperty("count_rank_s")]
        public int CountRankS { get; set; }

        [JsonProperty("count_rank_sh")]
        public int CountRankSPlus { get; set; }

        [JsonProperty("count_rank_a")]
        public int CountRankA { get; set; }

        [JsonProperty("country")]
        public string CountryCode { get; set; }

        [JsonProperty("total_seconds_played")]
        public uint TotalSecondsPlayed { get; set; }

        [JsonProperty("events")]
        public OsuLegacyUserEvent[] Events { get; set; }
    }
}
