// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using DragonFruit.Orbit.API.Objects.Generic;
using DragonFruit.Orbit.API.Objects.Interfaces;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Leaderboard
{
    public class OsuLeaderboardContainer<T> : IHasCursor where T : class
    {
        [JsonProperty("cursor")]
        public Cursor Cursor { get; set; }

        [JsonProperty("ranking")]
        public IOrderedEnumerable<T> TopScorers { get; set; }
    }
}
