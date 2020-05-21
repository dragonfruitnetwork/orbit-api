// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Scoring.Objects.Containers
{
    public class OsuUserScoreWeighting
    {
        [JsonProperty("percentage")]
        public double Percentage { get; set; }

        [JsonProperty("pp")]
        public double PP { get; set; }
    }
}
