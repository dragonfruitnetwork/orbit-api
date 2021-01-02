// Orbit API Copyright (C) 2019-2021 DragonFruit Network
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
        public double Percentage { get; set; }

        [JsonProperty("pp")]
        public double Value { get; set; }
    }
}
