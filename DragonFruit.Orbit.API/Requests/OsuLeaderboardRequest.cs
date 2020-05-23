// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.Interfaces;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuLeaderboardRequest : OrbitApiRequest, IRequiresMode
    {
        public override string Path => $"https://osu.ppy.sh/api/v2/rankings/{Mode.ToString().ToLowerInvariant()}/{Category.ToString().ToLowerInvariant()}";

        public OsuLeaderboardRequest(GameMode mode, OsuLeaderboardRankingType category)
        {
            Mode = mode;
            Category = category;
        }

        public GameMode Mode { get; set; }

        public OsuLeaderboardRankingType Category { get; set; }
    }
}
