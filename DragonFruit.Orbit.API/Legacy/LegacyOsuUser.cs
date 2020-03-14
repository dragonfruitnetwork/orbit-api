// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Legacy
{
    public class LegacyOsuUser
    {
        [JsonProperty("user_id")]
        public long Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("join_date")]
        public DateTimeOffset JoinDate { get; set; }

        [JsonProperty("count300")]
        public int Count300 { get; set; }

        [JsonProperty("count100")]
        public int Count100 { get; set; }

        [JsonProperty("count50")]
        public int Count50 { get; set; }

        [JsonProperty("playcount")]
        public long TotalPlays { get; set; }

        [JsonProperty("ranked_score")]
        public long RankedScore { get; set; }

        [JsonProperty("total_score")]
        public long TotalScore { get; set; }

        [JsonProperty("pp_rank")]
        public int GlobalRank { get; set; }

        [JsonProperty("level")]
        public float Level { get; set; }

        [JsonProperty("pp_raw")]
        public float PP { get; set; }

        [JsonProperty("accuracy")]
        public float Accuracy { get; set; }

        [JsonProperty("count_rank_ss")]
        public int RankSS { get; set; }

        [JsonProperty("count_rank_ssh")]
        public int RankSSPlus { get; set; }

        [JsonProperty("count_rank_sh")]
        public int RankSPlus { get; set; }

        [JsonProperty("count_rank_s")]
        public int RankS { get; set; }

        [JsonProperty("count_rank_a")]
        public int RankA { get; set; }

        [JsonProperty("country")]
        public string CountryCode { get; set; }

        [JsonProperty("pp_country_rank")]
        public long CountryRank { get; set; }

        [JsonProperty("total_seconds_played")]
        public long SecondsPlayed { get; set; }

        [JsonIgnore]
        public string AvatarUrl => $"http://s.ppy.sh/a/{Id}";
    }
}
