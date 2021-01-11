// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.User.Entities;
using DragonFruit.Orbit.Api.User.Requests;

namespace DragonFruit.Orbit.Api.User.Extensions
{
    public static class OsuUserExtensions
    {
        /// <summary>
        /// Lookup a user by their numeric identifier
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="id">The id of the user</param>
        /// <param name="mode">Optional mode to return stats for</param>
        public static OsuUser GetUser<T>(this T client, uint id, GameMode? mode = null) where T : OrbitClient
        {
            return GetUser(client, id.ToString(), mode);
        }

        /// <summary>
        /// Lookup a user by their numeric identifier
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="userId">The user id</param>
        /// <param name="mode">Optional mode name to return stats for</param>
        public static OsuUser GetUser<T>(this T client, uint userId, string mode) where T : OrbitClient
        {
            return GetUser(client, userId.ToString(), mode);
        }

        /// <summary>
        /// Lookup a user by their username
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="username">The username</param>
        /// <param name="mode">Optional mode to return stats for</param>
        public static OsuUser GetUser<T>(this T client, string username, GameMode? mode = null) where T : OrbitClient
        {
            var request = new OsuUserRequest(username, mode);
            return client.Perform<OsuUser>(request);
        }

        /// <summary>
        /// Lookup a user by their username
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="username">The username</param>
        /// <param name="mode">Optional mode name to return stats for</param>
        public static OsuUser GetUser<T>(this T client, string username, string mode) where T : OrbitClient
        {
            var request = new OsuUserRequest(username, mode);
            return client.Perform<OsuUser>(request);
        }
    }
}
