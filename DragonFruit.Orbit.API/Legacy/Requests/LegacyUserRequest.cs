// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Objects.Enums;

namespace DragonFruit.Orbit.API.Legacy.Requests
{
    public class LegacyUserRequest : LegacyEnumerableResponseRequest
    {
        public override string Path => "https://osu.ppy.sh/api/get_user";

        public LegacyUserRequest(string user, GameMode? mode)
        {
            User = user;
            IsUsername = true;
            GameMode = mode;
        }

        public LegacyUserRequest(uint userId, GameMode? mode)
        {
            User = userId.ToString();
            IsUsername = false;
            GameMode = mode;
        }

        [QueryParameter("event_days")]
        public uint? EventDays { get; set; }
    }
}
