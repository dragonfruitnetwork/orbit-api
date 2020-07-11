// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.Interfaces;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuLeaderboardRequest : OrbitApiRequest, IRequiresMode
    {
        protected override string Route => $"/rankings/{Mode.ToString().ToLowerInvariant()}/{Category.ToString().ToLowerInvariant()}";

        public OsuLeaderboardRequest(GameMode mode, OsuLeaderboardRankingType category)
        {
            Mode = mode;
            Category = category;
        }

        public GameMode Mode { get; set; }
        public OsuLeaderboardRankingType Category { get; set; }

        [QueryParameter("page")]
        public uint? Page { get; set; }
    }
}
