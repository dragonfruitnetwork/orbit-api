// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Orbit.API.Objects.User;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Comments
{
    public class OsuCommentsContainer
    {
        [JsonProperty("comments")]
        public IEnumerable<OsuComment> Comments { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("has_more_id")]
        public object HasMoreId { get; set; }

        [JsonProperty("included_comments")]
        public IEnumerable<OsuComment> IncludedComments { get; set; }

        [JsonProperty("pinned_comments")]
        public IEnumerable<OsuComment> PinnedComments { get; set; }

        [JsonProperty("user_votes")]
        public IEnumerable<uint> UserVotes { get; set; }

        [JsonProperty("user_follow")]
        public bool UserFollow { get; set; }

        [JsonProperty("users")]
        public IEnumerable<OsuCondensedUser> Users { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }

        [JsonProperty("cursor")]
        public OsuCommentsCursor Cursor { get; set; }

        [JsonProperty("top_level_count")]
        public uint TopLevelCount { get; set; }

        [JsonProperty("total")]
        public uint Total { get; set; }

        [JsonProperty("commentable_meta")]
        public List<OsuCommentsMeta> CommentableMeta { get; set; }
    }
}
