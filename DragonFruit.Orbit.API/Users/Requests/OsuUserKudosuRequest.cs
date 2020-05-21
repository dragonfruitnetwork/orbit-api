// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Users.Interfaces;

namespace DragonFruit.Orbit.API.Users.Requests
{
    public class OsuUserKudosuRequest : OrbitApiRequest, IRequiresUserId
    {
        public override string Path => $"https://osu.ppy.sh/api/v2/users/{UserId}/kudosu";

        public OsuUserKudosuRequest(uint userId)
        {
            UserId = userId;
        }

        public uint UserId { get; set; }
    }
}
