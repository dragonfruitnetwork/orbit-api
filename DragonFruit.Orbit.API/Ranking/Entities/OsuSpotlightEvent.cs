// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.Ranking.Enums;
using DragonFruit.Orbit.Api.Utils;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ranking.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuSpotlightEvent
    {
        private string _frequencyName;

        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("start_date")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTimeOffset EndDate { get; set; }

        [JsonProperty("mode_specific")]
        public bool ModeSpecific { get; set; }

        [JsonProperty("type")]
        public string FrequencyName
        {
            get => _frequencyName;
            set
            {
                _frequencyName = value;
                Frequency = EnumUtils.GetInternalValue<SpotlightFrequency>(value);
            }
        }

        public SpotlightFrequency? Frequency { get; set; }
    }
}
