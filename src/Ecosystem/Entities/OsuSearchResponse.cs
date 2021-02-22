// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.User.Entities;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuSearchResponse
    {
        [CanBeNull]
        [JsonProperty("user")]
        public OsuSearchResponseContainer<OsuUserCard> Users { get; set; }

        [CanBeNull]
        [JsonProperty("wiki_page")]
        public OsuSearchResponseContainer<OsuWikiPage> WikiPages { get; set; }
    }
}
