// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.API.Objects.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.User
{
    public class OsuUserRecentActivity
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("type")]
        private string TypeObject
        {
            set => Type = (OsuUserRecentActivityType)Enum.Parse(typeof(OsuUserRecentActivityType), value, true);
        }

        public OsuUserRecentActivityType Type { get; set; }

        [JsonProperty("scoreRank")]
        private string ScoreRankObject
        {
            set => ScoreRank = (OsuScoreGrade)Enum.Parse(typeof(OsuScoreGrade), value);
        }

        public OsuScoreGrade ScoreRank { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("approval")]
        public OsuUserBeatmapApproval Approval { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("beatmap")]
        public OsuRecentActivityBeatmap Beatmap { get; set; }

        [JsonProperty("beatmapset")]
        public OsuRecentActivityBeatmap Beatmapset { get; set; }

        [JsonProperty("user")]
        public RecentActivityUser User { get; set; }

        [JsonProperty("achievement")]
        public OsuRecentActivityAchievement Achievement { get; set; }
    }
}
