// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class BeatmapSet
    {
        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("covers")]
        public BeatmapCovers Covers { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("favourite_count")]
        public long FavouriteCount { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("play_count")]
        public long PlayCount { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }
    }
}
