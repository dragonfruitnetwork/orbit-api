// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.Api.Legacy.Requests
{
    public class OsuLegacyReplayRequest : OsuLegacyScoresRequest
    {
        public override string Target => "replay";

        // this is the same as a legacy score request but has no limit
        public override uint? Limit => null;
    }
}
