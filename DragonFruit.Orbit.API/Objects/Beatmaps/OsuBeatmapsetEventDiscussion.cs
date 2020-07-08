// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.API.Objects.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapsetEventDiscussion
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("beatmapset_id")]
        public long BeatmapsetId { get; set; }

        [JsonProperty("beatmap_id")]
        public long? BeatmapId { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("deleted_by_id")]
        public object DeletedById { get; set; }

        [JsonProperty("message_type")]
        public OsuBeatmapsetEventMessageType MessageType { get; set; }

        [JsonProperty("parent_id")]
        public object ParentId { get; set; }

        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        [JsonProperty("resolved")]
        public bool Resolved { get; set; }

        [JsonProperty("can_be_resolved")]
        public bool CanBeResolved { get; set; }

        [JsonProperty("can_grant_kudosu")]
        public bool CanGrantKudosu { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }

        [JsonProperty("last_post_at")]
        public DateTimeOffset LastPostAt { get; set; }

        [JsonProperty("kudosu_denied")]
        public bool KudosuDenied { get; set; }

        [JsonProperty("starting_post")]
        public OsuBeatmapsetEventsPost StartingPost { get; set; }
    }
}
