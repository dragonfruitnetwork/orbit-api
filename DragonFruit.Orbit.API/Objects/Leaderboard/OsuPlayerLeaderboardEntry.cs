// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.User;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Leaderboard
{
    /// <summary>
    /// Class for Leaderboards that reference individual players opposed to other objects like countries.
    /// </summary>
    public class OsuPlayerLeaderboardEntry
    {
        [JsonProperty("level")]
        public OsuUserLevel Level { get; set; }

        [JsonProperty("pp")]
        public decimal? PP { get; set; }

        [JsonProperty("pp_rank")]
        public int GlobalRank { get; set; }

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

        [JsonProperty("user")]
        public OsuUser User { get; set; }
    }
}
