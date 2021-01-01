// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ranking.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuScoreWeighting
    {
        [JsonProperty("percentage")]
        public float Percentage { get; set; }

        [JsonProperty("pp")]
        public float Value { get; set; }
    }
}
