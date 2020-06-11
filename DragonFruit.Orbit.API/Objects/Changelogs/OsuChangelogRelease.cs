// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Changelogs
{
    public class OsuChangelogRelease
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("display_version")]
        public string DisplayVersion { get; set; }

        [JsonProperty("users")]
        public long Users { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("update_stream")]
        public OsuChangelogStream UpdateStream { get; set; }

        [JsonProperty("changelog_entries")]
        public IEnumerable<OsuChangelogEntry> ChangelogEntries { get; set; }

        [JsonProperty("versions")]
        public OsuChangelogVersionCursor Versions { get; set; }

        public string Url => $"https://osu.ppy.sh/home/changelog/{UpdateStream.Name}/{Version}";

        public override string ToString() => $"{UpdateStream.DisplayName} {DisplayVersion}";
    }
}
