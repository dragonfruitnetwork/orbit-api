// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    public class OsuChangelogDetails
    {
        [JsonProperty("streams")]
        public IEnumerable<OsuChangelogTarget> Targets { get; set; }

        [JsonProperty("builds")]
        public IEnumerable<OsuChangelogRelease> Releases { get; set; }
    }
}
