// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.Beatmaps.Enums;
using DragonFruit.Orbit.Api.User.Enums;
using DragonFruit.Orbit.Api.Utils;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.User.Entities
{
    public class OsuRecentActivity
    {
        private string _typeName;
        private string _modeName;
        private string _scoreGradeName;

        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("type")]
        public string TypeName
        {
            get => _typeName;
            set
            {
                _typeName = value;
                Type = EnumUtils.GetInternalValue<OsuActivityType>(value);
            }
        }

        public OsuActivityType? Type { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset Date { get; set; }

        [CanBeNull]
        [JsonProperty("user")]
        public OsuRecentActivityUser User { get; set; }

        [CanBeNull]
        [JsonProperty("achievement")]
        public OsuUserAchievement Achievement { get; set; }

        #region Score

        [CanBeNull]
        [JsonProperty("scoreRank")]
        public string ScoreGradeName
        {
            get => _scoreGradeName;
            set
            {
                _scoreGradeName = value;
                ScoreGrade = EnumUtils.GetInternalValue<ScoreGrade>(value);
            }
        }

        [CanBeNull]
        [JsonProperty("mode")]
        public string ModeName
        {
            get => _modeName;
            set
            {
                _modeName = value;
                Mode = EnumUtils.GetInternalValue<GameMode>(value);
            }
        }

        [JsonProperty("rank")]
        public uint? Rank { get; set; }

        public GameMode? Mode { get; set; }
        public ScoreGrade? ScoreGrade { get; set; }

        #endregion

        #region Map

        [CanBeNull]
        [JsonProperty("beatmap")]
        public OsuRecentActivityMap Map { get; set; }

        [CanBeNull]
        [JsonProperty("beatmapset")]
        private OsuRecentActivityMap Mapset
        {
            set => Map = value;
        }

        [JsonProperty("approval")]
        public BeatmapsetStatus? BeatmapsetStatus { get; set; }

        #endregion
    }
}
