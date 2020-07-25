// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using DragonFruit.Orbit.API.Objects.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapInfo
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("beatmapset_id")]
        public uint BeatmapsetId { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        //todo check json
        public string Hash { get; set; }
        
        [JsonProperty("ranked")]
        public OsuBeatmapsetStatus Ranked { get; set; }

        [JsonProperty("mode")]
        public string ModeName { get; set; }

        [JsonProperty("mode_int")]
        public GameMode Mode { get; set; }

        [JsonProperty("convert")]
        public bool IsConverted { get; set; }

        [JsonProperty("ar")]
        public float AR { get; set; }

        [JsonProperty("cs")]
        public float CS { get; set; }

        [JsonProperty("drain")]
        public float Drain { get; set; }

        [JsonProperty("accuracy")]
        public float Accuracy { get; set; }

        [JsonProperty("difficulty_rating")]
        public float DifficultyRating { get; set; }

        [JsonProperty("bpm")]
        public float BPM { get; set; }

        [JsonProperty("count_circles")]
        public uint CountCircles { get; set; }

        [JsonProperty("count_sliders")]
        public uint CountSliders { get; set; }

        [JsonProperty("count_spinners")]
        public uint CountSpinners { get; set; }

        [JsonProperty("count_total")]
        public uint CountTotal { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("deleted_at")]
        public DateTimeOffset? DeletedAt { get; set; }

        [JsonProperty("hit_length")]
        public long HitLength { get; set; }

        [JsonProperty("is_scoreable")]
        public bool IsScoreable { get; set; }

        [JsonProperty("passcount")]
        public long Passcount { get; set; }

        [JsonProperty("playcount")]
        public long Playcount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("total_length")]
        public long TotalLength { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("max_combo")]
        public uint? MaxCombo { get; set; }

        [JsonProperty("failtimes")]
        public OsuBeatmapFailMetrics Fails { get; set; }

        [JsonProperty("ratings")]
        public IEnumerable<uint>? Ratings { get; set; }
    }
}
