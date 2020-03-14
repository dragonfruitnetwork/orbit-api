// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Users
{
    public class UserStatistics
    {
        [JsonProperty]
        public OsuUser User;

        [JsonProperty("level")]
        public LevelInfo Level { get; set; }

        [JsonProperty("pp")]
        public decimal? PP { get; set; }

        [JsonProperty("pp_rank")] // the API sometimes only returns this value in condensed user responses
        private int? Rank
        {
            set => Ranks.Global = value;
        }

        [JsonProperty("rank")]
        public UserRanks Ranks { get; set; } = new UserRanks();

        [JsonProperty("ranked_score")]
        public long RankedScore { get; set; }

        [JsonProperty("hit_accuracy")]
        public decimal Accuracy { get; set; }

        //[JsonIgnore]
        //public string DisplayAccuracy => Accuracy.FormatAccuracy();

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
        public Grades GradesCount { get; set; }

        public RankHistoryData RankHistory { get; set; }
    }
}
