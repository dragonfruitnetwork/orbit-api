// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.API.Enums;
using DragonFruit.Orbit.API.Enums.Maps;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Legacy
{
    public class LegacyScore
    {
        //ids
        [JsonProperty("beatmap_id")]
        public long BeatmapID { get; set; }

        [JsonProperty("score_id")]
        public long ScoreID { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        //context
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("username")]
        public string User { get; set; }

        //hit data
        [JsonProperty("count300")]
        public int Count300 { get; set; }

        /// <summary>
        /// Geki - all 300s/combo. Also used as the rainbow 300s in Mania (perfect)
        /// </summary>
        [JsonProperty("countgeki")]
        public int CountGeki { get; set; }

        [JsonProperty("count100")]
        public int Count100 { get; set; }

        /// <summary>
        /// 200s in mania
        /// </summary>
        [JsonProperty("countkatu")]
        public int CountKatu { get; set; }

        [JsonProperty("count50")]
        public int Count50 { get; set; }

        [JsonProperty("countmiss")]
        public int Count0 { get; set; }

        [JsonProperty("score")]
        public long PlayerScore { get; set; }

        //enums
        [JsonProperty("enabled_mods")]
        public Mods Mods { get; set; }

        [JsonProperty("rank")]
        public ScoreRank Rank { get; set; }

        //combo data
        [JsonProperty("maxcombo")]
        public int MaxCombo { get; set; }

        [JsonProperty("perfect")]
        public int Perfect { get; set; }

        //osu!database info
        [JsonProperty("pp")]
        public float Points { get; set; }

        [JsonProperty("replay_available")]
        public int IsReplayAvailable { get; set; }
    }
}
