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
        public float DifficultyRating { get; set; }

        [JsonProperty("accuracy")]
        public float Accuracy { get; set; }

        [JsonProperty("ar")]
        public float ApproachRate { get; set; }

        [JsonProperty("bpm")]
        public float BPM { get; set; }

        [JsonProperty("cs")]
        public float CircleSize { get; set; }

        [JsonProperty("drain")]
        public float Drain { get; set; }

        [JsonProperty("count_circles")]
        public uint CountCircles { get; set; }

        [JsonProperty("count_sliders")]
        public uint CountSliders { get; set; }

        [JsonProperty("count_spinners")]
        public uint CountSpinners { get; set; }

        [JsonProperty("covert")]
        public bool IsConverted { get; set; }

        [JsonProperty("max_combo")]
        public uint MaxCombo { get; set; }

        #endregion

        #region Length

        [JsonProperty("total_length")]
        public uint TotalLengthSeconds { get; set; }

        [JsonProperty("hit_length")]
        public uint HitLengthSeconds { get; set; }

        public TimeSpan TotalLength => _totalLength ??= TimeSpan.FromSeconds(TotalLengthSeconds);
        public TimeSpan HitLength => _hitLength ??= TimeSpan.FromSeconds(HitLengthSeconds);

        #endregion

        [JsonProperty("playcount")]
        public uint PlayCount { get; set; }

        [JsonProperty("passcount")]
        public uint PassCount { get; set; }

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
