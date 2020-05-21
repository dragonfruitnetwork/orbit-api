// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.API.Beatmaps.Enums;
using DragonFruit.Orbit.API.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Legacy.Objects
{
    public class LegacyBeatmap
    {
        //basic map info
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("creator")]
        public string Mapper { get; set; }

        [JsonProperty("artist")]
        public string ArtistName { get; set; }

        [JsonProperty("version")]
        public string DifficultyName { get; set; }

        [JsonProperty("file_md5")]
        public string BeatmapHash { get; set; }

        //times
        [JsonProperty("approved_date")]
        public DateTimeOffset ApprovedDate { get; set; }

        [JsonProperty("last_update")]
        public DateTimeOffset LastUpdated { get; set; }

        /// <summary>
        /// Total seconds from first note to last note including breaks
        /// </summary>
        [JsonProperty("hit_length")]
        public float SongNoteDuration { get; set; }

        //enums
        [JsonProperty("gameMode")]
        public GameMode GameMode { get; set; }

        [JsonProperty("approved")]
        public BeatmapsetStatus BeatmapStatus { get; set; }

        [JsonProperty("genere_id")]
        public SongGenre Genre { get; set; }

        [JsonProperty("language_id")]
        public Language Language { get; set; }

        //map ids
        [JsonProperty("beatmap_id")]
        public int BeatmapID { get; set; }

        [JsonProperty("beatmapset_id")]
        public int BeatmapSetID { get; set; }

        //computed map values
        [JsonProperty("bpm")]
        public float BPM { get; set; }

        [JsonProperty("difficultyrating")]
        public float StarValue { get; set; }

        [JsonProperty("diff_size")]
        public float CircleSize { get; set; }

        [JsonProperty("diff_overall")]
        public float OverallDifficulty { get; set; }

        [JsonProperty("diff_approach")]
        public float ApproachRate { get; set; }

        [JsonProperty("diff_drain")]
        public float DrainRate { get; set; }

        [JsonProperty("max_combo")]
        public int MaxCombo { get; set; }

        //tags
        [JsonProperty("tags")]
        public string TagList { get; set; }

        public string[] Tags => TagList.Split(' ');

        //map metrics
        [JsonProperty("favourite_count")]
        public int FavouriteCount { get; set; }

        [JsonProperty("playcount")]
        public int PlayCount { get; set; }

        [JsonProperty("passcount")]
        public int PassCount { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        //availability data
        [JsonProperty("storyboard")]
        public bool HasStoryboard { get; set; }

        [JsonProperty("video")]
        public bool HasVideo { get; set; }

        [JsonProperty("download_unavailable")]
        public bool DownloadUnavailable { get; set; }

        [JsonProperty("audio_unavailable")]
        public bool AudioUnavailable { get; set; }

        [JsonIgnore]
        public string Cover => $"https://assets.ppy.sh/beatmaps/{BeatmapSetID}/covers/cover.jpg";

        [JsonIgnore]
        public string Thumbnail => $"https://b.ppy.sh/thumb/{{BeatmapSetID}}l.jpg";
    }
}
