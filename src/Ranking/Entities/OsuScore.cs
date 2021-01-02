// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using DragonFruit.Orbit.Api.Beatmaps.Entities;
using DragonFruit.Orbit.Api.User.Entities;
using DragonFruit.Orbit.Api.User.Enums;
using DragonFruit.Orbit.Api.Utils;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ranking.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuScore
    {
        private string _gradeName;

        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("best_id")]
        public ulong BestScoreId { get; set; }

        [JsonProperty("user_id")]
        public uint UserId { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset DatePerformed { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("max_combo")]
        public uint MaxCombo { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("perfect")]
        public bool Perfect { get; set; }

        [JsonProperty("replay")]
        public bool ReplayAvailable { get; set; }

        [JsonProperty("pp")]
        public double? PP { get; set; }

        [CanBeNull]
        [JsonProperty("mods")]
        public IEnumerable<string> Mods { get; set; }

        [JsonProperty("rank")]
        public string GradeName
        {
            get => _gradeName;
            set
            {
                _gradeName = value;
                Grade = EnumUtils.GetInternalValue<ScoreGrade>(value);
            }
        }

        public ScoreGrade? Grade { get; set; }

        [CanBeNull]
        [JsonProperty("weight")]
        public OsuScoreWeighting Weighting { get; set; }

        [JsonProperty("statistics")]
        public OsuScoreStatistics Statistics { get; set; }

        [JsonProperty("beatmap")]
        public OsuBeatmap Beatmap { get; set; }

        [JsonProperty("beatmapset")]
        public OsuBeatmapsetCard Beatmapset { get; set; }

        [JsonProperty("user")]
        public OsuUserCard User { get; set; }
    }
}
