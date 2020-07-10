// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Comments
{
    public class OsuCommentsMeta
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("type")]
        public OsuCommentTarget Target { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("owner_id")]
        public uint? OwnerId { get; set; }
    }
}
