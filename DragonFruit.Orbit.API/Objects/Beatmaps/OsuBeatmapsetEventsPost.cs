// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapsetEventsPost
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("beatmap_discussion_id")]
        public long BeatmapDiscussionId { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("last_editor_id")]
        public long? LastEditorId { get; set; }

        [JsonProperty("deleted_by_id")]
        public object DeletedById { get; set; }

        [JsonProperty("system")]
        public bool System { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }
    }
}
