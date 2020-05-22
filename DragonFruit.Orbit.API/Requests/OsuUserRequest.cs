// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.Interfaces;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuUserRequest : OrbitApiRequest, IHasOptionalUserId, IHasOptionalMode
    {
        public override string Path => $"https://osu.ppy.sh/api/v2{(UserId.HasValue ? $"/users/{UserId}" : "/me")}/{(int?)Mode}";

        public OsuUserRequest()
        {
        }

        public OsuUserRequest(uint userId)
        {
            UserId = userId;
        }

        public uint? UserId { get; set; }

        public GameMode? Mode { get; set; }
    }
}
