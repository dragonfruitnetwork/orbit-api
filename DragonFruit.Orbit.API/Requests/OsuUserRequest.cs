// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.Interfaces;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuUserRequest : OrbitApiRequest, IHasOptionalMode
    {
        protected override string Route => $"{(!string.IsNullOrWhiteSpace(UserId) ? $"/users/{UserId}" : "/me")}/{((Mode ?? GameMode.Default) > GameMode.Default ? string.Empty : Mode.ToString().ToLowerInvariant())}";

        public OsuUserRequest()
        {
        }

        public OsuUserRequest(string identifier)
        {
            UserId = identifier;
        }

        public string UserId { get; set; }

        public GameMode? Mode { get; set; }
    }
}
