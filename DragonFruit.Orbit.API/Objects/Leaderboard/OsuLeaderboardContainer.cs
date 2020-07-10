// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DragonFruit.Orbit.API.Objects.Leaderboard
{
    public class OsuLeaderboardContainer<T> where T : class
    {
        [JsonProperty("cursor")]
        public IDictionary<string, JToken> Cursor { get; set; }

        [JsonProperty("ranking")]
        public IOrderedEnumerable<T> TopScorers { get; set; }
    }
}
