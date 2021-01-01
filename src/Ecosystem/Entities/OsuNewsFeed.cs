// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using DragonFruit.Orbit.Api.Interfaces;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuNewsFeed : IPaginatedByCursor
    {
        [JsonProperty("news_posts")]
        public IEnumerable<OsuNewsEntry> Entries { get; set; }

        [JsonProperty("cursor")]
        public IReadOnlyDictionary<string, string> Cursor { get; set; }
    }
}
