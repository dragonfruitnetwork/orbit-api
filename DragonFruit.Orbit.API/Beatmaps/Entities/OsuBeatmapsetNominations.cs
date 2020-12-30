// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Beatmaps.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuBeatmapsetNominations
    {
        [JsonProperty("current")]
        public uint Current { get; set; }

        [JsonProperty("required")]
        public uint Required { get; set; }
    }
}
