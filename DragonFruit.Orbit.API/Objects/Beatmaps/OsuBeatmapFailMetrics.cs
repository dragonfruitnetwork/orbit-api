// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapFailMetrics
    {
        [JsonProperty("fail")]
        public IEnumerable<uint> Fail { get; set; }

        [JsonProperty("exit")]
        public IEnumerable<uint> Quit { get; set; }
    }
}
