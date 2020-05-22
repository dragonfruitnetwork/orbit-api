// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.User
{
    public class OsuBadge
    {
        [JsonProperty("awarded_at")]
        public DateTimeOffset AwardedAt;

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }
}
