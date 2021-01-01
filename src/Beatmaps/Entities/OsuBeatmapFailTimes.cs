// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Beatmaps.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuBeatmapFailTimes
    {
        [JsonProperty("fail")]
        public IEnumerable<uint> Fail { get; set; }

        [JsonProperty("exit")]
        public IEnumerable<uint> Exit { get; set; }
    }
}
