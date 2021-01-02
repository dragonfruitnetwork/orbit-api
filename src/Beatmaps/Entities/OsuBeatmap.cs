// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.Beatmaps.Enums;
using DragonFruit.Orbit.Api.Utils;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Beatmaps.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuBeatmap
    {
        private string _modeName, _statusName;
        private TimeSpan? _totalLength, _hitLength;

        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("beatmapset_id")]
        public uint BeatmapsetId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("version")]
        public string Name { get; set; }

        #region Ratings/Difficulty Attributes

        [JsonProperty("difficulty_rating")]
        public double DifficultyRating { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("ar")]
        public double ApproachRate { get; set; }

        [JsonProperty("bpm")]
        public double BPM { get; set; }

        [JsonProperty("cs")]
        public double CircleSize { get; set; }

        [JsonProperty("drain")]
        public double Drain { get; set; }

        [JsonProperty("count_circles")]
        public int CountCircles { get; set; }

        [JsonProperty("count_sliders")]
        public int CountSliders { get; set; }

        [JsonProperty("count_spinners")]
        public int CountSpinners { get; set; }

        [JsonProperty("covert")]
        public bool IsConverted { get; set; }

        [JsonProperty("max_combo")]
        public int MaxCombo { get; set; }

        #endregion

        #region Length

        [JsonProperty("total_length")]
        public int TotalLengthSeconds { get; set; }

        [JsonProperty("hit_length")]
        public int HitLengthSeconds { get; set; }

        public TimeSpan TotalLength => _totalLength ??= TimeSpan.FromSeconds(TotalLengthSeconds);
        public TimeSpan HitLength => _hitLength ??= TimeSpan.FromSeconds(HitLengthSeconds);

        #endregion

        [JsonProperty("playcount")]
        public int PlayCount { get; set; }

        [JsonProperty("passcount")]
        public int PassCount { get; set; }

        [CanBeNull]
        [JsonProperty("failtimes")]
        public OsuBeatmapFailTimes Fails { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public DateTimeOffset? DeletedAt { get; set; }

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

        [JsonProperty("status")]
        public string StatusName
        {
            get => _statusName;
            set
            {
                _statusName = value;
                Status = EnumUtils.GetInternalValue<BeatmapsetStatus>(value);
            }
        }

        public GameMode? Mode { get; set; }
        public BeatmapsetStatus? Status { get; set; }
    }
}
