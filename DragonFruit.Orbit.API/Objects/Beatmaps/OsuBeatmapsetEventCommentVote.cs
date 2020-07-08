// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapsetEventCommentVote
    {
        [JsonProperty("user_id")]
        public uint UserId { get; set; }

        [JsonProperty("score")]
        public uint Score { get; set; }
    }
}
