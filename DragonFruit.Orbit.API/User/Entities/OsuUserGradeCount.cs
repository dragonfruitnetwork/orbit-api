// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.User.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuUserGradeCount
    {
        [JsonProperty("a")]
        public uint CountA { get; set; }

        [JsonProperty("s")]
        public uint CountS { get; set; }

        [JsonProperty("sh")]
        public uint CountSPlus { get; set; }

        [JsonProperty("ss")]
        public uint CountSS { get; set; }

        [JsonProperty("ssh")]
        public uint CountSSPlus { get; set; }
    }
}
