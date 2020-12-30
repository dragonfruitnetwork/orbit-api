// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuWikiPage
    {
        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("path")]
        public string PathStub { get; set; }

        [JsonProperty("markdown")]
        public string Content { get; set; }

        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }
    }
}
