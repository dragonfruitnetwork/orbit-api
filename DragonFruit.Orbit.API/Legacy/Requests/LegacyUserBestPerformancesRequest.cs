// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Enums;

namespace DragonFruit.Orbit.API.Legacy.Requests
{
    public class LegacyUserBestPerformancesRequest : LegacyRequest, IHasLimiter
    {
        public override string Path => "https://osu.ppy.sh/api/get_user_best";

        public LegacyUserBestPerformancesRequest(string user, GameMode mode)
        {
            User = user;
            IsUsername = true;
            GameMode = mode;
        }

        public LegacyUserBestPerformancesRequest(uint userId, GameMode mode)
        {
            User = userId.ToString();
            IsUsername = false;
            GameMode = mode;
        }

        public uint? Limit { get; set; }
    }
}
