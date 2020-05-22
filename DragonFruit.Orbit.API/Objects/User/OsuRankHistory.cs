// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.User
{
    public class OsuRankHistory
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("data")]
        public int[] Data { get; set; }
    }
}
