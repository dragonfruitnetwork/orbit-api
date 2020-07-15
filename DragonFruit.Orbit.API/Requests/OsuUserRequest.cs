// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.Interfaces;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuUserRequest : OrbitApiRequest, IHasOptionalMode
    {
        protected override string Route => $"{(!string.IsNullOrWhiteSpace(UserId) ? $"/users/{UserId}" : "/me")}/{Mode.ToQueryableValue()}";

        /// <summary>
        /// Get the token owner's account
        /// </summary>
        public OsuUserRequest()
        {
        }

        /// <summary>
        /// Get the token owner's account for the specified mode
        /// </summary>
        public OsuUserRequest(GameMode mode)
        {
            Mode = mode;
        }

        /// <summary>
        /// Get a user's account info based on their username or id for their preferred mode
        /// </summary>
        public OsuUserRequest(string identifier)
        {
            UserId = identifier;
        }

        /// <summary>
        /// Get a user's account info based on their username or id
        /// </summary>
        public OsuUserRequest(string identifier, GameMode mode)
        {
            UserId = identifier;
            Mode = mode;
        }

        public string UserId { get; set; }
        public GameMode? Mode { get; set; }
    }
}
