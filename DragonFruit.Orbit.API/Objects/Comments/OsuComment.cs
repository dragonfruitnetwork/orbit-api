// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.API.Objects.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Comments
{
    public class OsuComment
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("parent_id")]
        public uint? ParentId { get; set; }

        [JsonProperty("user_id")]
        public uint UserId { get; set; }

        [JsonProperty("pinned")]
        public bool Pinned { get; set; }

        [JsonProperty("replies_count")]
        public uint RepliesCount { get; set; }

        [JsonProperty("votes_count")]
        public uint VotesCount { get; set; }

        [JsonProperty("commentable_type")]
        private string CommentTargetString
        {
            get => CommentTarget.ToQueryable();
            set => CommentTarget = OsuCommentTargetExtensions.FromQueryable(value);
        }

        [JsonIgnore]
        public OsuCommentTarget CommentTarget { get; set; }

        [JsonProperty("commentable_id")]
        public uint? CommentableId { get; set; }

        [JsonProperty("legacy_name")]
        public string LegacyName { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public DateTimeOffset? DeletedAt { get; set; }

        [JsonProperty("edited_at")]
        public DateTimeOffset? EditedAt { get; set; }

        [JsonProperty("edited_by_id")]
        public uint? EditedById { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("message_html")]
        public string MessageHtml { get; set; }
    }
}
