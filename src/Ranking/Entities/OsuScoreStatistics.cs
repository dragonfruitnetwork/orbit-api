// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ranking.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuScoreStatistics
    {
        [JsonProperty("count_50")]
        public int Count50 { get; set; }

        [JsonProperty("count_100")]
        public int Count100 { get; set; }

        [JsonProperty("count_300")]
        public int Count300 { get; set; }

        [JsonProperty("count_geki")]
        public int CountGeki { get; set; }

        [JsonProperty("count_katu")]
        public int CountKatu { get; set; }

        [JsonProperty("count_miss")]
        public int CountMiss { get; set; }
    }
}
