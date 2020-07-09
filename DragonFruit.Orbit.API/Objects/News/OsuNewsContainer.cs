// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.News
{
    public class OsuNewsContainer
    {
        [JsonProperty("news_posts")]
        public IEnumerable<OsuNewsPostInfo> Posts { get; set; }

        [JsonProperty("cursor")]
        public OsuNewsCursor Cursor { get; set; }
    }
}
