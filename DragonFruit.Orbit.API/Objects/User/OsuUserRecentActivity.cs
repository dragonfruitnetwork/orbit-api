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
        public int ID;

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("type")]
        private string TypeObject
        {
            set => Type = (RecentActivityType)Enum.Parse(typeof(RecentActivityType), value, true);
        }

        public RecentActivityType Type;

        [JsonProperty("scoreRank")]
        private string ScoreRankObject
        {
            set => ScoreRank = (ScoreRank)Enum.Parse(typeof(ScoreRank), value);
        }

        public ScoreRank ScoreRank;

        [JsonProperty("rank")]
        public int Rank;

        [JsonProperty("approval")]
        public OsuUserBeatmapApproval Approval;

        [JsonProperty("count")]
        public int Count;

        [JsonProperty("mode")]
        public string Mode;

        [JsonProperty("beatmap")]
        public OsuRecentActivityBeatmap Beatmap;

        [JsonProperty("beatmapset")]
        public OsuRecentActivityBeatmap Beatmapset;

        [JsonProperty("user")]
        public RecentActivityUser User;

        [JsonProperty("achievement")]
        public RecentActivityAchievement Achievement;
    }
}
