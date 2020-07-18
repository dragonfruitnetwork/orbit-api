// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.API.Objects.Beatmaps;
using DragonFruit.Orbit.API.Objects.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.User
{
    public class OsuUserScoreInfo
    {
        [JsonProperty("id")]
        public ulong? Id { get; set; }

        [JsonProperty("best_id")]
        public ulong? BestId { get; set; }

        [JsonProperty("user_id")]
        public uint UserId { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("mods")]
        public string[] Mods { get; set; }

        [JsonProperty("score")]
        public uint Score { get; set; }

        [JsonProperty("max_combo")]
        public uint MaxCombo { get; set; }

        [JsonProperty("perfect")]
        public bool Perfect { get; set; }

        [JsonProperty("statistics")]
        public OsuUserScoreInfoStatistics Statistics { get; set; }

        [JsonProperty("pp")]
        public double? PP { get; set; }

        [JsonProperty("rank")]
        public OsuScoreGrade Grade { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("mode")]
        public string ModeName { get; set; }

        [JsonProperty("mode_int")]
        public GameMode Mode { get; set; }

        [JsonProperty("replay")]
        public bool ReplayAvailable { get; set; }

        [JsonProperty("beatmap")]
        public OsuBeatmapInfo Beatmap { get; set; }

        [JsonProperty("beatmapset")]
        public OsuBeatmapsetInfo Beatmapset { get; set; }

        [JsonProperty("weight")]
        public OsuUserScoreWeighting Weight { get; set; }

        [JsonProperty("user")]
        public OsuUser User { get; set; }
    }
}
