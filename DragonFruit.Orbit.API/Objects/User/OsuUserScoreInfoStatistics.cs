// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.User
{
    public class OsuUserScoreInfoStatistics
    {
        [JsonProperty("count_50")]
        public uint Count50 { get; set; }

        [JsonProperty("count_100")]
        public uint Count100 { get; set; }

        [JsonProperty("count_300")]
        public uint Count300 { get; set; }

        [JsonProperty("count_geki")]
        public uint CountGeki { get; set; }

        [JsonProperty("count_katu")]
        public uint CountKatu { get; set; }

        [JsonProperty("count_miss")]
        public uint CountMiss { get; set; }
    }
}
