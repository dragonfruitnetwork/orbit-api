// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.Legacy.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Legacy.Entities
{
    public class OsuLegacyMap
    {
        [JsonProperty("beatmap_id")]
        public uint BeatmapId { get; set; }

        [JsonProperty("beatmapset_id")]
        public uint BeatmapsetId { get; set; }

        [JsonProperty("mode")]
        public LegacyMode Mode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("approved")]
        public LegacyRankingStatus Status { get; set; }

        [JsonProperty("max_combo")]
        public uint MaxCombo { get; set; }

        [JsonProperty("file_md5")]
        public string FileHash { get; set; }

        [JsonProperty("creator")]
        public string Mapper { get; set; }

        [JsonProperty("creator_id")]
        public uint MapperId { get; set; }

        [JsonProperty("submit_date")]
        public DateTime SubmittedUtc { get; set; }

        [JsonProperty("last_update")]
        public DateTime LastUpdateUtc { get; set; }

        [JsonProperty("approved_date")]
        public DateTime? ApprovedUtc { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("genre_id")]
        public long Genre { get; set; }

        [JsonProperty("language_id")]
        public long Language { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("rating")]
        public float Rating { get; set; }

        [JsonProperty("favourite_count")]
        public uint FavouriteCount { get; set; }

        [JsonProperty("playcount")]
        public uint PlayCount { get; set; }

        [JsonProperty("passcount")]
        public uint PassCount { get; set; }

        [JsonProperty("hit_length")]
        public uint HitLength { get; set; }

        [JsonProperty("total_length")]
        public uint TotalLength { get; set; }

        [JsonProperty("count_normal")]
        public uint ObjectCountNormal { get; set; }

        [JsonProperty("count_slider")]
        public uint ObjectCountSlider { get; set; }

        [JsonProperty("count_spinner")]
        public uint ObjectCountSpinner { get; set; }

        [JsonProperty("bpm")]
        public float BPM { get; set; }

        [JsonProperty("difficultyrating")]
        public float DifficultyRating { get; set; }

        [JsonProperty("diff_aim")]
        public float DifficultyAim { get; set; }

        [JsonProperty("diff_speed")]
        public float DifficultySpeed { get; set; }

        [JsonProperty("diff_size")]
        public float DifficultySize { get; set; }

        [JsonProperty("diff_overall")]
        public float DifficultyOverall { get; set; }

        [JsonProperty("diff_approach")]
        public float DifficultyApproach { get; set; }

        [JsonProperty("diff_drain")]
        public float DifficultyDrain { get; set; }

        [JsonProperty("storyboard")]
        public LegacyBool Storyboard { get; set; }

        [JsonProperty("video")]
        public LegacyBool Video { get; set; }

        [JsonProperty("download_unavailable")]
        public LegacyBool DownloadBlocked { get; set; }

        [JsonProperty("audio_unavailable")]
        public LegacyBool AudioBlocked { get; set; }
    }
}
