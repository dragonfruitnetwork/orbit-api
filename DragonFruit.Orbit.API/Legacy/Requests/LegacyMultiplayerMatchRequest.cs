// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.API.Legacy.Requests
{
    public class LegacyMultiplayerMatchRequest : LegacyRequest
    {
        public override string Path => "https://osu.ppy.sh/api/get_match";

        public LegacyMultiplayerMatchRequest(uint matchId)
        {
            MatchId = matchId;
        }

        [QueryParameter("mp")]
        public uint MatchId { get; set; }
    }
}
