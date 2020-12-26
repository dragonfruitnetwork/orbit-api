// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Interfaces;
using DragonFruit.Orbit.Api.Utils;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    public class OsuCommentsSummary : IPaginatedResponse
    {
        [JsonProperty("has_more")]
        public bool More { get; set; }

        [JsonProperty("has_more_id")]
        public uint? ModeId { get; set; }

        [JsonProperty("sort")]
        [JsonConverter(typeof(ExternalEnumConverter))]
        public CommentSort SortedBy { get; set; }

        // todo add users and user votes

        [JsonProperty("comments")]
        public IEnumerable<OsuComment> Comments { get; set; }

        [JsonProperty("pinned_comments")]
        public IEnumerable<OsuComment> PinnedComments { get; set; }

        [JsonProperty("included_comments")]
        public IEnumerable<OsuComment> IncludedComments { get; set; }

        [JsonProperty("commentable_meta")]
        public IEnumerable<OsuCommentableMetadata> Metadata { get; set; }

        [JsonProperty("cursor")]
        public IReadOnlyDictionary<string, string> Cursor { get; set; }
    }
}
