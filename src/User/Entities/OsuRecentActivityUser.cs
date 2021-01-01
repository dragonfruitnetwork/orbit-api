// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.User.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuRecentActivityUser
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("url")]
        public string UrlStub { get; set; }

        [JsonProperty("previousUsername")]
        public string PreviousUsername { get; set; }
    }
}
