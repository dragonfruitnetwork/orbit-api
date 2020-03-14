// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.API.Users.Requests
{
    public class OsuUserRequest : ModeBasedRequest
    {
        public override string Path => $"https://osu.ppy.sh/api/v2/users/{UserId}/{ModeValue}";

        public int UserId { get; set; }
    }
}
