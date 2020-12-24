// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Legacy.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Legacy.Entities
{
    public class OsuLegacyMatchScore : OsuLegacyScore
    {
        [JsonProperty("pass")]
        public LegacyBool Passed { get; set; }

        [JsonProperty("slot")]
        public uint PlayerSlot { get; set; }

        [JsonProperty("team")]
        public LegacyTeam Team { get; set; }
    }
}
