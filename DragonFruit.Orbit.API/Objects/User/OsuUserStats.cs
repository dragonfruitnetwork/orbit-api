// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.User
{
    public class OsuUserStats
    {
        [JsonProperty("user")]
        public OsuUser User { get; set; }

        [JsonProperty("level")]
        public OsuUserLevel Level { get; set; }

        [JsonProperty("pp")]
        public decimal? PP { get; set; }

        [JsonProperty("pp_rank")]
        private int? Rank
        {
            set => Ranks.Global = value;
        }

        [JsonProperty("rank")]
        public OsuUserRanks Ranks { get; set; } = new OsuUserRanks();

        [JsonProperty("ranked_score")]
        public long RankedScore { get; set; }

        [JsonProperty("hit_accuracy")]
        public decimal Accuracy { get; set; }

        [JsonProperty("play_count")]
        public int PlayCount { get; set; }

        [JsonProperty("play_time")]
        public int? PlayTime { get; set; }

        [JsonProperty("total_score")]
        public long TotalScore { get; set; }

        [JsonProperty("total_hits")]
        public int TotalHits { get; set; }

        [JsonProperty("maximum_combo")]
        public int MaxCombo { get; set; }

        [JsonProperty("replays_watched_by_others")]
        public int ReplaysWatched { get; set; }

        [JsonProperty("grade_counts")]
        public OsuGrades GradesCount { get; set; }

        public OsuRankHistory RankHistory { get; set; }
    }
}
