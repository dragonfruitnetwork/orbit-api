// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.User.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuUserAboutPage
    {
        [JsonProperty("raw")]
        public string Raw { get; set; }

        [JsonProperty("html")]
        public string HtmlFormatted { get; set; }
    }
}
