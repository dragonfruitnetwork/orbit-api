// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Orbit.API.Objects.User;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapsetEventsResultContainer
    {
        [JsonProperty("events")]
        public IEnumerable<OsuBeatmapsetEvent> Events { get; set; }

        [JsonProperty("users")]
        public IEnumerable<OsuCondensedUser> Users { get; set; }
    }
}
