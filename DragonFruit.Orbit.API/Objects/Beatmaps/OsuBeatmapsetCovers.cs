// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapsetCovers
    {
        [JsonProperty("cover")]
        public string Cover { get; set; }

        [JsonProperty("cover@2x")]
        public string Cover2X { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("card@2x")]
        public string Card2X { get; set; }

        [JsonProperty("list")]
        public string List { get; set; }

        [JsonProperty("list@2x")]
        public string List2X { get; set; }

        [JsonProperty("slimcover")]
        public string Slimcover { get; set; }

        [JsonProperty("slimcover@2x")]
        public string Slimcover2X { get; set; }
    }
}
