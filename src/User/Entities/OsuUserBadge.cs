// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.User.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuUserBadge
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("awarded_at")]
        public DateTimeOffset AwardedAt { get; set; }

        [CanBeNull]
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
