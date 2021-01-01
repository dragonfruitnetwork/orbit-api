// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.Api.Legacy.Requests
{
    public class OsuLegacyMatchRequest : OsuLegacyRequest
    {
        public override string Target => "match";

        public OsuLegacyMatchRequest(uint matchId)
        {
            MatchId = matchId;
        }

        [QueryParameter("mp")]
        public uint MatchId { get; set; }
    }
}
