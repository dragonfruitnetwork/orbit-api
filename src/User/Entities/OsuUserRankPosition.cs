// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.User.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuUserRankPosition
    {
        [JsonProperty("global")]
        public uint Global { get; set; }

        [JsonProperty("country")]
        public uint Country { get; set; }
    }
}
