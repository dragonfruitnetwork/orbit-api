// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Spotlights
{
    public class OsuSpotlightsInfoContainer
    {
        [JsonProperty("spotlights")]
        public IEnumerable<OsuSpotlightEntry> Spotlights { get; set; }
    }
}
