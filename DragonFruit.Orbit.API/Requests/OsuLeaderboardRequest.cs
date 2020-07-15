// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.Interfaces;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuLeaderboardRequest : OrbitPaginatedRequest, IRequiresMode
    {
        protected override string Route => $"/rankings/{Mode.ToQueryableValue()}/{Category.ToString().ToLowerInvariant()}";
        protected override bool UsesOffset => true;

        /// <summary>
        /// Get the global leaderboard for a specific mode and category
        /// </summary>
        public OsuLeaderboardRequest(GameMode mode, OsuLeaderboardRankingType category)
        {
            Mode = mode;
            Category = category;
        }

        public GameMode Mode { get; set; }
        public OsuLeaderboardRankingType Category { get; set; }
    }
}
