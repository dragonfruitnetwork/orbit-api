// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using DragonFruit.Orbit.API.Enums;
using DragonFruit.Orbit.API.Enums.Maps;
using DragonFruit.Orbit.API.Enums.Multi;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Legacy
{
    public class LegacyMultiplayerMatch
    {
        [JsonProperty("match")]
        public LegacyMultiplayerMatchInfo GameInfo { get; set; }

        [JsonProperty("games")]
        public IEnumerable<LegacyMultiplayerGame> Rounds { get; set; }
    }

    public class LegacyMultiplayerMatchInfo
    {
        [JsonProperty("match_id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_time")]
        public DateTimeOffset Start { get; set; }

        [JsonProperty("end_time")]
        public DateTimeOffset? End { get; set; }

        [JsonIgnore]
        public bool IsOngoing => End == null;
    }

    public class LegacyMultiplayerGame
    {
        [JsonProperty("game_id")]
        public ulong Id { get; set; }

        [JsonProperty("start_time")]
        public DateTimeOffset Start { get; set; }

        [JsonProperty("end_time")]
        public DateTimeOffset End { get; set; }

        [JsonProperty("beatmap_id")]
        public uint BeatmapId { get; set; }

        [JsonProperty("play_mode")]
        public GameModes GameMode { get; set; }

        [JsonProperty("scoring_type")]
        public WinCondition ScoreType { get; set; }

        [JsonProperty("team_type")]
        public TeamType TeamType { get; set; }

        [JsonProperty("mods")]
        public Mods GlobalMods { get; set; }

        [JsonProperty("scores")]
        public IEnumerable<LegacyMutliplayerScore> Scores { get; set; }
    }
}
