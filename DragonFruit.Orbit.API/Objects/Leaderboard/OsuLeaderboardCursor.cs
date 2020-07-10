// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Leaderboard
{
    /// <summary>
    /// Object used for tracking what items have been sent, i.e. a page number
    /// </summary>
    public class OsuLeaderboardCursor
    {
        [JsonIgnore]
        public int Page => NextPage - 1;

        [JsonProperty("page")]
        public int NextPage { get; set; }
    }
}
