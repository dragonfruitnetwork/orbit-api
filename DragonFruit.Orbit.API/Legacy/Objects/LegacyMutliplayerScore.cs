// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Legacy.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Legacy.Objects
{
    public class LegacyMutliplayerScore : LegacyScore
    {
        [JsonProperty("slot")]
        public uint Slot { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("pass")]
        public bool Passed { get; set; }
    }
}
