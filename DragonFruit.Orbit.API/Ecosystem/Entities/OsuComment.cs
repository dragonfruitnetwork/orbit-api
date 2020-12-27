// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Utils;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuComment
    {
        private string _commentableTypeName;

        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("parent_id")]
        public uint? ParentId { get; set; }

        [JsonProperty("user_id")]
        public uint UserId { get; set; }

        [JsonProperty("pinned")]
        public bool Pinned { get; set; }

        [JsonProperty("replies_count")]
        public uint ReplyCount { get; set; }

        [JsonProperty("votes_count")]
        public uint VoteCount { get; set; }

        [JsonProperty("commentable_type")]
        public string CommentableTypeName
        {
            get => _commentableTypeName;
            set
            {
                _commentableTypeName = value;
                CommentableType = EnumUtils.GetInternalValue<CommentableType>(value);
            }
        }

        public CommentableType? CommentableType { get; set; }

        [JsonProperty("commentable_id")]
        public uint CommentableId { get; set; }

        [CanBeNull]
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
        public uint? EditedBy { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("message_html")]
        public string MessageHtml { get; set; }
    }
}
