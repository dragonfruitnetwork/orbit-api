// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Leaderboards.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuSpotlightsContainer
    {
        [JsonProperty("spotlights")]
        public IEnumerable<OsuSpotlightEvent> Events { get; set; }
    }
}
