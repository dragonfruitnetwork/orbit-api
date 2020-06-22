// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.User;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapScoreInfo
    {
        [JsonProperty(@"score")]
        public int TotalScore { get; set; }

        [JsonProperty(@"max_combo")]
        public int MaxCombo { get; set; }

        [JsonProperty(@"user")]
        public OsuUser User { get; set; }

        [JsonProperty(@"id")]
        public long OnlineScoreID { get; set; }

        [JsonProperty(@"replay")]
        public bool Replay { get; set; }

        [JsonProperty(@"created_at")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty(@"beatmap")]
        public OsuBeatmapInfo Beatmap { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty(@"pp")]
        public double? PP { get; set; }

        [JsonProperty(@"beatmapset")]
        public OsuBeatmapInfo Metadata { get; set; }

        [JsonProperty(@"statistics")]
        public Dictionary<string, int> Statistics { get; set; }

        [JsonProperty(@"mode_int")]
        public int OnlineRulesetID { get; set; }

        [JsonProperty(@"mods")]
        public string[] Mods { get; set; }

        [JsonProperty("rank")]
        [JsonConverter(typeof(StringEnumConverter))]
        public OsuScoreGrade Grade { get; set; }
    }
}
