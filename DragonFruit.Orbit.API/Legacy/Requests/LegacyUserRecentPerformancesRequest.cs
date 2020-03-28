// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Enums;
using DragonFruit.Orbit.API.Legacy.Requests.Interfaces;

namespace DragonFruit.Orbit.API.Legacy.Requests
{
    public class LegacyUserRecentPerformancesRequest : LegacyRequestBase, IHasLimiter
    {
        public LegacyUserRecentPerformancesRequest(string user, bool isUsername = true, GameModes gameMode = GameModes.Standard)
        {
            User = user;
            IsUsername = isUsername;
            GameMode = gameMode;
        }

        public override string Path => "https://osu.ppy.sh/api/get_user_recent";

        public uint? Limit { get; set; }
    }
}
