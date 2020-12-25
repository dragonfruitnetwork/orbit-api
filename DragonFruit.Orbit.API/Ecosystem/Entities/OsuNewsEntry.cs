// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    public class OsuNewsEntry
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("preview")]
        public string Preview { get; set; }

        [JsonProperty("first_image")]
        public string Image { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("published_at")]
        public DateTimeOffset PublishedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset LastUpdatedAt { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("edit_url")]
        public string EditUrl { get; set; }
    }
}
