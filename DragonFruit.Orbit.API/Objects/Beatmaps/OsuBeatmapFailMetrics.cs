// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapFailMetrics
    {
        [JsonProperty("fail")]
        public IOrderedEnumerable<uint> Fail { get; set; }

        [JsonProperty("exit")]
        public IOrderedEnumerable<uint> Quit { get; set; }
    }
}
