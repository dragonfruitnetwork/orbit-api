// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapsetEventComment
    {
        [JsonProperty("beatmap_discussion_id")]
        public uint? BeatmapDiscussionId { get; set; }

        [JsonProperty("beatmap_discussion_post_id")]
        public uint? BeatmapDiscussionPostId { get; set; }

        [JsonProperty("new_vote")]
        public OsuBeatmapsetEventCommentVote? NewVote { get; set; }

        [JsonProperty("votes")]
        public IEnumerable<OsuBeatmapsetEventCommentVote>? Votes { get; set; }
    }
}
