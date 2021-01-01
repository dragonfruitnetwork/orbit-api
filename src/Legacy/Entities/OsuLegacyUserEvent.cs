// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Legacy.Entities
{
    [Serializable]
    public class OsuLegacyUserEvent
    {
        [JsonProperty("display_html")]
        public string HtmlContent { get; set; }

        [JsonProperty("beatmap_id")]
        public uint BeatmapId { get; set; }

        [JsonProperty("beatmapset_id")]
        public uint BeatmapsetId { get; set; }

        [JsonProperty("date")]
        public DateTime DateUtc { get; set; }

        [JsonProperty("epicfactor")]
        public uint EpicFactor { get; set; }
    }
}
