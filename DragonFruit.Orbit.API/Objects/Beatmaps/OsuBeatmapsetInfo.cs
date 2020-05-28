// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using DragonFruit.Orbit.API.Objects.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapsetInfo
    {
        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("creator")]
        public string Mapper { get; set; }

        [JsonProperty("favourite_count")]
        public long FavouriteCount { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("play_count")]
        public long PlayCount { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("bpm")]
        public float BPM { get; set; }

        [JsonProperty("video")]
        public bool HasVideo { get; set; }

        [JsonProperty("can_be_hyped")]
        public bool Hypeable { get; set; }

        [JsonProperty("discussion_enabled")]
        public bool Discussable { get; set; }

        [JsonProperty("discussion_locked")]
        public bool DiscussionLocked { get; set; }

        [JsonProperty("is_scoreable")]
        public bool Scoreable { get; set; }

        [JsonProperty("storyboard")]
        public bool HasStoryboard { get; set; }

        [JsonProperty("submission_date")]
        public DateTimeOffset SubmissionDate { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdate { get; set; }

        [JsonProperty("ranked_date")]
        public DateTimeOffset? RankedDate { get; set; }

        [JsonProperty("legacy_thread_url")]
        public string LegacyThreadUrl { get; set; }

        [JsonProperty("tags")]
        private string TagsObject
        {
            set => Tags = value.Split(' ');
        }

        public string[] Tags { get; set; }

        [JsonProperty("ranked")]
        public OsuBeatmapsetStatus RankedStatus { get; set; }

        [JsonProperty("covers")]
        public OsuBeatmapsetCovers Covers { get; set; }

        [JsonProperty("availability")]
        public OsuBeatmapAvailability Availability { get; set; }

        [JsonProperty("hype")]
        public OsuBeatmapRequirementMetric Hype { get; set; }

        [JsonProperty("nominations")]
        public OsuBeatmapRequirementMetric Nominations { get; set; }

        [JsonProperty("beatmaps")]
        public IEnumerable<OsuBeatmapInfo> Beatmaps { get; set; }
    }
}
