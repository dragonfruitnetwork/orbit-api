// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Interfaces;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuUserKudosuRequest : OrbitApiRequest, IRequiresUserId
    {
        protected override string Route => $"/users/{UserId}/kudosu";

        public OsuUserKudosuRequest(uint userId)
        {
            UserId = userId;
        }

        public uint UserId { get; set; }
    }
}