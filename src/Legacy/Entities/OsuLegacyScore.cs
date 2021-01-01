// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.Legacy.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Legacy.Entities
{
    [Serializable]
    public class OsuLegacyScore
    {
        [JsonProperty("user_id")]
        public uint UserId { get; set; }

        [JsonProperty("beatmap_id")]
        public uint BeatmapId { get; set; }

        [JsonProperty("score")]
        public uint Score { get; set; }

        [JsonProperty("max_combo")]
        public uint MaxCombo { get; set; }

        [JsonProperty("rank")]
        public LegacyRank Rank { get; set; }

        [JsonProperty("perfect")]
        public LegacyBool Perfect { get; set; }

        [JsonProperty("count300")]
        public uint Count300 { get; set; }

        [JsonProperty("count100")]
        public uint Count100 { get; set; }

        [JsonProperty("count50")]
        public uint Count50 { get; set; }

        [JsonProperty("countmiss")]
        public uint CountMiss { get; set; }

        [JsonProperty("countgeki")]
        public uint CountGeki { get; set; }

        [JsonProperty("countkatu")]
        public uint CountKatu { get; set; }

        [JsonProperty("date")]
        public DateTime TimePerformedUtc { get; set; }

        [JsonProperty("enabled_mods")]
        public LegacyMods? ModsEnabled { get; set; }
    }
}
