// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuSeasonalBackgroundCollection
    {
        [JsonProperty("ends_at")]
        public DateTimeOffset EndsAt { get; set; }

        [JsonProperty("backgrounds")]
        public IEnumerable<OsuSeasonalBackground> Backgrounds { get; set; }
    }
}
