// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.API.Beatmaps.Objects;
using DragonFruit.Orbit.API.Scoring.Objects.Containers;
using DragonFruit.Orbit.API.Users.Objects;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Scoring.Objects
{
    public class OsuUserScoreInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("best_id")]
        public long BestId { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("mods")]
        public string[] Mods { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("max_combo")]
        public long MaxCombo { get; set; }

        [JsonProperty("perfect")]
        public bool Perfect { get; set; }

        [JsonProperty("statistics")]
        public OsuUserScoreInfoStatistics Statistics { get; set; }

        [JsonProperty("pp")]
        public double PP { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("mode_int")]
        public long ModeInt { get; set; }

        [JsonProperty("replay")]
        public bool Replay { get; set; }

        [JsonProperty("beatmap")]
        public Beatmap Beatmap { get; set; }

        [JsonProperty("beatmapset")]
        public BeatmapSet Beatmapset { get; set; }

        [JsonProperty("weight")]
        public OsuUserScoreWeighting Weight { get; set; }

        [JsonProperty("user")]
        public OsuUser User { get; set; }
    }
}
