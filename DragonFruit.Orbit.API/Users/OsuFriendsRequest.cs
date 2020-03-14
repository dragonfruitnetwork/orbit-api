using DragonFruit.Common.Data;

namespace DragonFruit.Orbit.API.Users
{
    public class OsuFriendsRequest : ApiRequest
    {
        public override string Path => "https://osu.ppy.sh/api/v2/friends";

        public override bool RequireAuth => true;
    }
}
