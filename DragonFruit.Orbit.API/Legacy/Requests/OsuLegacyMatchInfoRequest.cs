// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.Api.Legacy.Requests
{
    public class OsuLegacyMatchInfoRequest : OrbitLegacyRequest
    {
        public override string Target => "match";

        [QueryParameter("mp")]
        public uint MatchId { get; set; }
    }
}
