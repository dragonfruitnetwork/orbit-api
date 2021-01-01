// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Beatmaps.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuBeatmapsetAvailability
    {
        [JsonProperty("download_disabled")]
        public bool DownloadDisabled { get; set; }

        [CanBeNull]
        [JsonProperty("more_information")]
        public string Info { get; set; }
    }
}
