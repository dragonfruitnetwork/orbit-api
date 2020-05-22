// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.User
{
    public class OsuUserCover
    {
        [JsonProperty("custom_url")]
        public string CustomUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}
