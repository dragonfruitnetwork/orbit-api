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
        public int CountA { get; set; }

        [JsonProperty("s")]
        public int CountS { get; set; }

        [JsonProperty("sh")]
        public int CountSPlus { get; set; }

        [JsonProperty("ss")]
        public int CountSS { get; set; }

        [JsonProperty("ssh")]
        public int CountSSPlus { get; set; }
    }
}
