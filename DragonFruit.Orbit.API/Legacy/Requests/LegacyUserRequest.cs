// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Enums;

namespace DragonFruit.Orbit.API.Legacy.Requests
{
    public class LegacyUserRequest : LegacyRequestBase
    {
        public LegacyUserRequest(string user, bool isUsername = true, Modes mode = Modes.Standard)
        {
            User = user;
            IsUsername = isUsername;
            Mode = mode;
        }

        public override string Path => "https://osu.ppy.sh/api/get_user";

        [QueryParameter("event_days")]
        public uint? EventDays { get; set; }
    }
}
