// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Legacy.Entities
{
    [Serializable]
    public class OsuLegacyMatch
    {
        [JsonProperty("match")]
        public OsuLegacyMatchInfo Info { get; set; }

        [JsonProperty("games")]
        public IEnumerable<OsuLegacyMatchRound> Rounds { get; set; }
    }
}
