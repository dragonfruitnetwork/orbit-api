// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Objects.Enums;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuSpotlightsLeaderboardRequest : OsuLeaderboardRequest
    {
        public OsuSpotlightsLeaderboardRequest(GameMode mode)
            : base(mode, OsuLeaderboardRankingType.Charts)
        {
        }

        public OsuSpotlightsLeaderboardRequest(GameMode mode, uint chartId)
            : base(mode, OsuLeaderboardRankingType.Charts)
        {
            SpotlightsId = chartId;
        }

        [QueryParameter("spotlight")]
        public uint? SpotlightsId { get; set; }
    }
}
