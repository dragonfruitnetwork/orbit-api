// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.API.Legacy.Converters;
using DragonFruit.Orbit.API.Objects.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Legacy.Objects
{
    public class LegacyScore
    {
        //ids
        [JsonProperty("beatmap_id")]
        public uint BeatmapID { get; set; }

        [JsonProperty("score_id")]
        public ulong ScoreID { get; set; }

        [JsonProperty("user_id")]
        public uint UserId { get; set; }

        //context
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("username")]
        public string User { get; set; }

        //hit data
        [JsonProperty("count300")]
        public uint Count300 { get; set; }

        /// <summary>
        /// Geki - all 300s/combo. Also used as the rainbow 300s in Mania (perfect)
        /// </summary>
        [JsonProperty("countgeki")]
        public uint CountGeki { get; set; }

        [JsonProperty("count100")]
        public uint Count100 { get; set; }

        /// <summary>
        /// 200s in mania
        /// </summary>
        [JsonProperty("countkatu")]
        public uint CountKatu { get; set; }

        [JsonProperty("count50")]
        public uint Count50 { get; set; }

        [JsonProperty("countmiss")]
        public uint Count0 { get; set; }

        [JsonProperty("score")]
        public uint PlayerScore { get; set; }

        //enums
        [JsonProperty("enabled_mods")]
        public OsuMods? Mods { get; set; }

        [JsonProperty("rank")]
        public OsuScoreGrade Rank { get; set; }

        //combo data
        [JsonProperty("maxcombo")]
        public uint MaxCombo { get; set; }

        [JsonProperty("perfect"), JsonConverter(typeof(BoolConverter))]
        public bool Perfect { get; set; }

        //osu!database info
        [JsonProperty("pp")]
        public float Points { get; set; }

        [JsonProperty("replay_available"), JsonConverter(typeof(BoolConverter))]
        public bool IsReplayAvailable { get; set; }
    }
}
