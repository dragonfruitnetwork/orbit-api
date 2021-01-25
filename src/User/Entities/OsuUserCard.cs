// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.User.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuUserCard
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("default_group")]
        public string DefaultGroup { get; set; }
        
        [JsonProperty("current_mode_rank")]
        public int? CurrentModeRank { get; set; }

        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        [JsonProperty("is_bot")]
        public bool IsBot { get; set; }

        [JsonProperty("is_online")]
        public bool IsOnline { get; set; }

        [JsonProperty("is_supporter")]
        public bool IsSupporter { get; set; }

        [JsonProperty("support_level")]
        public int SupportLevel { get; set; }

        [JsonProperty("last_visit")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonProperty("pm_friends_only")]
        public bool MessagingRestricted { get; set; }

        [CanBeNull]
        [JsonProperty("profile_colour")]
        public string ProfileColour { get; set; }

        [JsonProperty("cover")]
        public OsuUserCover Cover { get; set; }

        [JsonProperty("country")]
        public OsuUserCountry Country { get; set; }

        [CanBeNull]
        [JsonProperty("groups")]
        public IEnumerable<OsuUserGroup> Groups { get; set; }
    }
}
