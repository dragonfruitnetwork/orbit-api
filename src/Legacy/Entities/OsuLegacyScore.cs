// Orbit API Copyright (C) 2019-2021 DragonFruit Network
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
        public int Score { get; set; }

        [JsonProperty("max_combo")]
        public int MaxCombo { get; set; }

        [JsonProperty("rank")]
        public LegacyRank Rank { get; set; }

        [JsonProperty("perfect")]
        public LegacyBool Perfect { get; set; }

        [JsonProperty("count300")]
        public int Count300 { get; set; }

        [JsonProperty("count100")]
        public int Count100 { get; set; }

        [JsonProperty("count50")]
        public int Count50 { get; set; }

        [JsonProperty("countmiss")]
        public int CountMiss { get; set; }

        [JsonProperty("countgeki")]
        public int CountGeki { get; set; }

        [JsonProperty("countkatu")]
        public int CountKatu { get; set; }

        [JsonProperty("score_id")]
        public ulong? ScoreId { get; set; }

        [JsonProperty("pp")]
        public double? PP { get; set; }

        [JsonProperty("replay_available")]
        public LegacyBool? ReplayAvailable { get; set; }

        [JsonProperty("date")]
        public DateTime TimePerformedUtc { get; set; }

        [JsonProperty("enabled_mods")]
        public LegacyMods? ModsEnabled { get; set; }
    }
}
