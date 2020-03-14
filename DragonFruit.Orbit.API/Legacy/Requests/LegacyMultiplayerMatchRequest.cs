// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Legacy.Requests.Interfaces;

namespace DragonFruit.Orbit.API.Legacy.Requests
{
    public class LegacyMultiplayerMatchRequest : ApiRequest, IRequiresApiKey
    {
        public LegacyMultiplayerMatchRequest(uint matchId)
        {
            MatchId = matchId;
        }

        public override string Path => "https://osu.ppy.sh/api/get_match";

        [QueryParameter("k")]
        public string ApiKey { get; set; }

        [QueryParameter("mp")]
        public uint MatchId { get; set; }
    }
}
