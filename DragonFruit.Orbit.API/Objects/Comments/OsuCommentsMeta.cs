// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Comments
{
    public class OsuCommentsMeta
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("type")]
        private string CommentTargetString
        {
            get => CommentTarget.ToQueryable();
            set => CommentTarget = OsuCommentTargetExtensions.FromQueryable(value);
        }

        [JsonIgnore]
        public OsuCommentTarget CommentTarget { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("owner_id")]
        public uint? OwnerId { get; set; }
    }
}
