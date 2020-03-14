// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;

namespace DragonFruit.Orbit.API.Users
{
    public class OsuRecentActivityRequest : ApiRequest
    {
        public override string Path => $"https://osu.ppy.sh/api/v2/users/{UserId}/recent_activity";

        public override bool RequireAuth => true;

        public uint UserId { get; set; }
    }
}
