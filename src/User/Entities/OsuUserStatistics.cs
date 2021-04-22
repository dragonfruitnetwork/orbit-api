﻿// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.User.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuUserStatistics
    {
        [JsonProperty("is_ranked")]
        public bool IsRanked { get; set; }

        [JsonProperty("grade_counts")]
        public OsuUserGradeCount Grades { get; set; }

        [JsonProperty("level")]
        public OsuUserLevelProgress Level { get; set; }

        [JsonProperty("pp")]
        public double? Performance { get; set; }

        [JsonProperty("global_rank")]
        public int? GlobalRank { get; set; }

        [JsonProperty("country_rank")]
        public int? CountryRank { get; set; }

        [JsonProperty("hit_accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("maximum_combo")]
        public int MaxCombo { get; set; }

        [JsonProperty("play_count")]
        public uint TotalPerformances { get; set; }

        [JsonProperty("total_hits")]
        public uint TotalHits { get; set; }

        [JsonProperty("total_score")]
        public ulong TotalScore { get; set; }

        [JsonProperty("ranked_score")]
        public ulong RankedScore { get; set; }

        [JsonProperty("play_time")]
        public uint SecondsPlayed { get; set; }

        public TimeSpan TimePlayed => TimeSpan.FromSeconds(SecondsPlayed);

        [CanBeNull]
        [JsonProperty("user")]
        public OsuUserCard User { get; set; }
    }
}
