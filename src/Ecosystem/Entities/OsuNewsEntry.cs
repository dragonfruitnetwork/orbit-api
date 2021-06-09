﻿// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuNewsEntry
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [CanBeNull]
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
