// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Legacy.Objects
{
    public class LegacyOsuUser
    {
        [JsonProperty("user_id")]
        public uint Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("join_date")]
        public DateTimeOffset JoinDate { get; set; }

        [JsonProperty("count300")]
        public uint Count300 { get; set; }

        [JsonProperty("count100")]
        public uint Count100 { get; set; }

        [JsonProperty("count50")]
        public uint Count50 { get; set; }

        [JsonProperty("playcount")]
        public uint TotalPlays { get; set; }

        [JsonProperty("ranked_score")]
        public ulong RankedScore { get; set; }

        [JsonProperty("total_score")]
        public ulong TotalScore { get; set; }

        [JsonProperty("pp_rank")]
        public uint GlobalRank { get; set; }

        [JsonProperty("level")]
        public float Level { get; set; }

        [JsonProperty("pp_raw")]
        public float PP { get; set; }

        [JsonProperty("accuracy")]
        public float Accuracy { get; set; }

        [JsonProperty("count_rank_ss")]
        public uint RankSS { get; set; }

        [JsonProperty("count_rank_ssh")]
        public uint RankSSPlus { get; set; }

        [JsonProperty("count_rank_sh")]
        public uint RankSPlus { get; set; }

        [JsonProperty("count_rank_s")]
        public uint RankS { get; set; }

        [JsonProperty("count_rank_a")]
        public uint RankA { get; set; }

        [JsonProperty("country")]
        public string CountryCode { get; set; }

        [JsonProperty("pp_country_rank")]
        public uint CountryRank { get; set; }

        [JsonProperty("total_seconds_played")]
        public ulong SecondsPlayed { get; set; }

        [JsonIgnore]
        public string AvatarUrl => $"https://s.ppy.sh/a/{Id}";
    }
}
