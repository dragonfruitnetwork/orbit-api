// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Scoring.Objects.Containers
{
    public class OsuUserScoreInfoStatistics
    {
        [JsonProperty("count_50")]
        public long Count50 { get; set; }

        [JsonProperty("count_100")]
        public long Count100 { get; set; }

        [JsonProperty("count_300")]
        public long Count300 { get; set; }

        [JsonProperty("count_geki")]
        public long CountGeki { get; set; }

        [JsonProperty("count_katu")]
        public long CountKatu { get; set; }

        [JsonProperty("count_miss")]
        public long CountMiss { get; set; }
    }
}
