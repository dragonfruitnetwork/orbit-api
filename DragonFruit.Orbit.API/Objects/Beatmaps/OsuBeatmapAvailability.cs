// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Beatmaps
{
    public class OsuBeatmapAvailability
    {
        [JsonProperty("download_disabled")]
        public bool DownloadDisabled { get; set; }

        [JsonProperty("more_information")]
        public string? Notes { get; set; }
    }
}
