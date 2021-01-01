// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Legacy.Entities
{
    [Serializable]
    public class OsuLegacyMatchInfo
    {
        [JsonProperty("match_id")]
        public uint Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_time")]
        public DateTime StartTimeUtc { get; set; }

        [JsonProperty("end_time")]
        public DateTime? EndTimeUtc { get; set; }

        [JsonIgnore]
        public bool MatchEnded => EndTimeUtc.HasValue;
    }
}
