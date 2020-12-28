// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.User.Entities
{
    public class OsuUserLevelProgress
    {
        [JsonProperty("current")]
        public uint Current { get; set; }

        [JsonProperty("progress")]
        public float Progress { get; set; }
    }
}
