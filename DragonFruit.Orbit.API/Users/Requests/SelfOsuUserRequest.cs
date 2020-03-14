namespace DragonFruit.Orbit.API.Users.Requests
{
    public class SelfOsuUserRequest : ModeBasedRequest
    {
        public override string Path => $"https://osu.ppy.sh/api/v2/me/{ModeValue}";
    }
}
