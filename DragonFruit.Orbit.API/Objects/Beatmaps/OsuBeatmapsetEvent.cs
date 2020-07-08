// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.API.Objects.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapsetEvent
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("type")]
        public OsuBeatmapsetEventType Type { get; set; }

        [JsonProperty("comment")]
        public OsuBeatmapsetEventComment Comment { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("user_id")]
        public uint? UserId { get; set; }

        [JsonProperty("beatmapset")]
        public OsuBeatmapsetInfo Beatmapset { get; set; }

        [JsonProperty("discussion")]
        public OsuBeatmapsetEventDiscussion? Discussion { get; set; }
    }
}
