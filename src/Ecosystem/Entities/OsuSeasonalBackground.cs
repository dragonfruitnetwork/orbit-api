// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.User.Entities;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuSeasonalBackground
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("user")]
        public OsuUserCard User { get; set; }
    }
}
