// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using DragonFruit.Orbit.Api.Legacy.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Legacy.Entities
{
    public class OsuLegacyMatchRound
    {
        [JsonProperty("game_id")]
        public uint Id { get; set; }

        [JsonProperty("start_time")]
        public DateTime StartTimeUtc { get; set; }

        [JsonProperty("end_time")]
        public DateTime EndTimeUtc { get; set; }

        [JsonIgnore]
        public TimeSpan Duration => EndTimeUtc - StartTimeUtc;

        [JsonProperty("beatmap_id")]
        public uint BeatmapId { get; set; }

        [JsonProperty("play_mode")]
        public LegacyMode Mode { get; set; }

        [JsonProperty("scoring_type")]
        public LegacyWinCondition ScoreMode { get; set; }

        [JsonProperty("team_type")]
        public LegacyTeamType TeamMode { get; set; }

        [JsonProperty("mods")]
        public LegacyMods? GlobalMods { get; set; }

        [JsonProperty("scores")]
        public IEnumerable<OsuLegacyMatchScore> Scores { get; set; }
    }
}
