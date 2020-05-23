// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Spotlights
{
    public class OsuSpotlightEntry
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_date")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTimeOffset EndDate { get; set; }

        //todo enum????
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("mode_specific")]
        public bool ModeSpecific { get; set; }
    }
}
