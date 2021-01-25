// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using System.Linq;
using DragonFruit.Orbit.Api.User.Enums;
using DragonFruit.Orbit.Api.Utils;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.User.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuUser : OsuUserCard
    {
        private string _defaultModeName;
        private IEnumerable<string> _playstyleNames;

        // removed for now as everything can be retrieved from the cover object
        // [NotNull]
        // [JsonProperty("cover_url")]
        // public string CoverUrl { get; set; }

        [JsonProperty("has_supported")]
        public bool HasSupported { get; set; }

        [JsonProperty("support_level")]
        public int? SupporterLevel { get; set; }

        #region Socials

        [CanBeNull]
        [JsonProperty("discord")]
        public string Discord { get; set; }

        [CanBeNull]
        [JsonProperty("interests")]
        public string Interests { get; set; }

        [CanBeNull]
        [JsonProperty("location")]
        public string Location { get; set; }

        [CanBeNull]
        [JsonProperty("occupation")]
        public string Occupation { get; set; }

        [CanBeNull]
        [JsonProperty("skype")]
        public string Skype { get; set; }

        [CanBeNull]
        [JsonProperty("website")]
        public string Website { get; set; }

        [CanBeNull]
        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        #endregion

        [CanBeNull]
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("join_date")]
        public DateTimeOffset JoinDate { get; set; }

        [JsonProperty("kudosu")]
        public OsuUserKudosuSummary Kudosu { get; set; }

        [JsonProperty("rank_history")]
        public OsuUserRankHistory RankHistory { get; set; }

        [JsonProperty("statistics")]
        public OsuUserStatistics Statistics { get; set; }

        [CanBeNull]
        [JsonProperty("page")]
        public OsuUserAboutPage Page { get; set; }

        #region Counts

        [JsonProperty("post_count")]
        public int PostCount { get; set; }

        [JsonProperty("favourite_beatmapset_count")]
        public int FavouriteMapsetCount { get; set; }

        [JsonProperty("graveyard_beatmapset_count")]
        public int GraveyardMapsetCount { get; set; }

        [JsonProperty("loved_beatmapset_count")]
        public uint LovedMapsetCount { get; set; }

        [JsonProperty("ranked_and_approved_beatmapset_count")]
        public uint RankedMapsetCount { get; set; }

        [JsonProperty("follower_count")]
        public uint FollowerCount { get; set; }

        [JsonProperty("max_friends")]
        public uint MaxFriendCount { get; set; }

        [JsonProperty("max_blocks")]
        public uint MaxBlockCount { get; set; }

        [JsonProperty("scores_first_count")]
        public uint FirstPlaceCount { get; set; }

        #endregion

        #region Access

        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("is_bng")]
        public bool IsBNG { get; set; }

        [JsonProperty("is_full_bn")]
        public bool IsFullBN { get; set; }

        [JsonProperty("is_gmt")]
        public bool IsGMT { get; set; }

        [JsonProperty("is_limited_bn")]
        public bool IsLimitedBN { get; set; }

        [JsonProperty("is_moderator")]
        public bool IsModerator { get; set; }

        [JsonProperty("is_nat")]
        public bool IsNAT { get; set; }

        [JsonProperty("is_restricted")]
        public bool IsRestricted { get; set; }

        [JsonProperty("is_silenced")]
        public bool IsSilenced { get; set; }

        #endregion

        public GameMode? DefaultMode { get; set; }
        public UserPlaystyle? Playstyle { get; set; }

        [JsonProperty("playmode")]
        public string DefaultModeName
        {
            get => _defaultModeName;
            set
            {
                _defaultModeName = value;
                DefaultMode = EnumUtils.GetInternalValue<GameMode>(value);
            }
        }

        [JsonProperty("playstyle")]
        public IEnumerable<string> PlaystyleNames
        {
            get => _playstyleNames;
            set
            {
                _playstyleNames = value;

                var values = value.Select(EnumUtils.GetInternalValue<UserPlaystyle>).Where(x => x != null).ToArray();
                Playstyle = values.Any() ? values.Aggregate((a, b) => a | b) : null;
            }
        }

        [JsonProperty("profile_order")]
        public IEnumerable<string> ProfileOrder { get; set; }

        [CanBeNull]
        [JsonProperty("badges")]
        public IEnumerable<OsuUserBadge> Badges { get; set; }

        [JsonProperty("user_achievements")]
        public IEnumerable<OsuUserAchievement> Achievements { get; set; }

        [CanBeNull]
        [JsonProperty("previous_usernames")]
        public IEnumerable<string> PreviousNames { get; set; }

        [CanBeNull]
        [JsonProperty("replays_watched_counts")]
        public IEnumerable<OsuStatisticsPeriod<uint>> ReplayWatchCounts { get; set; }

        [JsonProperty("monthly_playcounts")]
        public IEnumerable<OsuStatisticsPeriod<uint>> PlayCounts { get; set; }
    }
}
