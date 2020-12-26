// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Utils;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    public class OsuCommentableMetadata
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(ExternalEnumConverter))]
        public CommentableType Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("owner_id")]
        public uint? OwnerId { get; set; }

        [JsonProperty("owner_title")]
        public string OwnerTitle { get; set; }
    }
}
