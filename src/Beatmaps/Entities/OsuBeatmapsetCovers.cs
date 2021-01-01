// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Beatmaps.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class OsuBeatmapsetCovers
    {
        [JsonProperty("cover")]
        public string Cover { get; set; }

        [JsonProperty("cover@2x")]
        public string Cover2x { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("card@2x")]
        public string Card2x { get; set; }

        [JsonProperty("list")]
        public string List { get; set; }

        [JsonProperty("list@2x")]
        public string List2x { get; set; }

        [JsonProperty("slimcover")]
        public string SlimCover { get; set; }

        [JsonProperty("slimcover@2x")]
        public string SlimCover2x { get; set; }
    }
}
