// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    public class OsuChangelogRelease
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("display_version")]
        public string DisplayVersion { get; set; }

        [JsonProperty("users")]
        public uint? Users { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("update_stream")]
        public OsuChangelogTarget Target { get; set; }

        [JsonProperty("changelog_entries")]
        public IEnumerable<OsuChangelogEntry> Entries { get; set; }
    }
}
