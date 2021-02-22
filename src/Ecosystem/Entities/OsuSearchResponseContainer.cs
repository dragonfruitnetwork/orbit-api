// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuSearchResponseContainer<T>
    {
        [JsonProperty("data")]
        public IEnumerable<T> Items { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
