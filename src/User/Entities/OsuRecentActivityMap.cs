// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.User.Entities
{
    public class OsuRecentActivityMap
    {
        [JsonProperty("title")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string UrlStub { get; set; }
    }
}
