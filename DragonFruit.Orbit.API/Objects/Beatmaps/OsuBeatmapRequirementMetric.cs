// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapRequirementMetric
    {
        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("required")]
        public int Required { get; set; }
    }
}
