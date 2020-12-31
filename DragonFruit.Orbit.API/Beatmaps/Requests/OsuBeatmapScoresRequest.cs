// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Ranking.Enums;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Beatmaps.Requests
{
    public class OsuBeatmapScoresRequest : OsuBeatmapInfoRequest
    {
        protected override string Stub => $"{base.Stub}/scores";

        public OsuBeatmapScoresRequest(uint id)
            : base(id)
        {
        }

        public LeaderboardType? LeaderboardType { get; set; }

        [QueryParameter("type")]
        protected string LeaderboardTypeName => LeaderboardType.ToExternalValue();
    }
}
