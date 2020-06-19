// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Changelogs
{
    /// <remarks>
    /// The <see cref="Streams"/> has access to <see cref="OsuChangelogRelease.ChangelogEntries"/> but will return nothing.
    /// If this is needed then use the Releases property
    /// </remarks>
    public class OsuChangelogIndex
    {
        [JsonProperty("builds")]
        public IEnumerable<OsuChangelogRelease> Releases { get; set; }

        [JsonProperty("streams")]
        public IEnumerable<OsuChangelogStreamInfo> Streams { get; set; }
    }
}
