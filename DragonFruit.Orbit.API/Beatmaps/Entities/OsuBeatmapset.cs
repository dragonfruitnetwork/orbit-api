// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using DragonFruit.Orbit.Api.Beatmaps.Enums;
using DragonFruit.Orbit.Api.User.Entities;
using DragonFruit.Orbit.Api.Utils;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Beatmaps.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuBeatmapset
    {
        private string _statusName;

        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("title_unicode")]
        public string TitleUnicode { get; set; }

        [JsonProperty("artist_unicode")]
        public string ArtistUnicode { get; set; }

        [JsonProperty("covers")]
        public OsuBeatmapsetCovers Covers { get; set; }

        [JsonProperty("description")]
        public OsuBeatmapsetDescription Description { get; set; }

        [JsonProperty("creator")]
        public string Mapper { get; set; }

        [JsonProperty("user_id")]
        public uint MapperUserId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("play_count")]
        public uint PlayCount { get; set; }

        [JsonProperty("favourite_count")]
        public uint FavouriteCount { get; set; }

        #region Dates

        [JsonProperty("submitted_date")]
        public DateTimeOffset SubmittedAt { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdatedAt { get; set; }

        [JsonProperty("ranked_date")]
        public DateTimeOffset? RankedAt { get; set; }

        #endregion

        #region Ranking

        [JsonProperty("is_scoreable")]
        public bool IsScoreable { get; set; }

        [JsonProperty("can_be_hyped")]
        public bool IsHypeable { get; set; }

        [JsonProperty("hype")]
        public uint? HypeCount { get; set; }

        [JsonProperty("nominations_summary")]
        public OsuBeatmapsetNominations Nominations { get; set; }

        #endregion

        [JsonProperty("tags")]
        public string Tags { get; set; }

        #region Flags

        [JsonProperty("video")]
        public bool HasVideo { get; set; }

        [JsonProperty("storyboard")]
        public bool HasStoryboard { get; set; }

        [JsonProperty("discussion_enabled")]
        public bool DiscussionEnabled { get; set; }

        [JsonProperty("discussion_locked")]
        public bool DiscussionLocked { get; set; }

        [JsonProperty("legacy_thread_url")]
        public string LegacyThreadUrl { get; set; }

        #endregion

        #region Audio

        [JsonProperty("preview_url")]
        public string AudioPreview { get; set; }

        [JsonProperty("bpm")]
        public float BPM { get; set; }

        #endregion

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

        public BeatmapsetStatus? Status { get; set; }

        [JsonProperty("availability")]
        public OsuBeatmapsetAvailability Availability { get; set; }

        [JsonProperty("language")]
        public OsuBeatmapsetCategory Language { get; set; }

        [JsonProperty("genre")]
        public OsuBeatmapsetCategory Genre { get; set; }

        [JsonProperty("beatmaps")]
        public IEnumerable<OsuBeatmap> Maps { get; set; }

        [JsonProperty("converts")]
        public IEnumerable<OsuBeatmap> ConvertedMaps { get; set; }

        [JsonProperty("ratings")]
        public IEnumerable<uint> Ratings { get; set; }

        [JsonProperty("recent_favourites")]
        public IEnumerable<OsuUserCard> RecentFavourites { get; set; }

        [JsonProperty("user")]
        public OsuUserCard MapperUser { get; set; }
    }
}
