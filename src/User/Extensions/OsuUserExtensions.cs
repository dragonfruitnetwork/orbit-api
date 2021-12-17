// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using System.Threading.Tasks;
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
        public static Task<OsuUser> GetUser(this OrbitClient client, uint id, GameMode? mode = null)
        {
            return GetUser(client, id.ToString(), mode, false);
        }

        /// <summary>
        /// Lookup a user by their numeric identifier
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="userId">The user id</param>
        /// <param name="mode">Optional mode name to return stats for</param>
        public static Task<OsuUser> GetUser(this OrbitClient client, uint userId, string mode)
        {
            return GetUser(client, userId.ToString(), mode, false);
        }

        /// <summary>
        /// Lookup a user by their username
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="identifier">The username</param>
        /// <param name="mode">Optional mode to return stats for</param>
        /// <param name="isUsername">Whether the <see cref="identifier"/> represents a username. If unset, the server will guess</param>
        public static Task<OsuUser> GetUser(this OrbitClient client, string identifier, GameMode? mode = null, bool? isUsername = null)
        {
            var request = new OsuUserRequest(identifier, mode)
            {
                IsUsername = isUsername
            };

            return client.PerformAsync<OsuUser>(request);
        }

        /// <summary>
        /// Lookup a user by their username
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="identifier">The username</param>
        /// <param name="mode">Optional mode name to return stats for</param>
        /// <param name="isUsername">Whether the <see cref="identifier"/> represents a username. If unset, the server will guess</param>
        public static Task<OsuUser> GetUser(this OrbitClient client, string identifier, string mode, bool? isUsername = null)
        {
            var request = new OsuUserRequest(identifier, mode)
            {
                IsUsername = isUsername
            };

            return client.PerformAsync<OsuUser>(request);
        }

        /// <summary>
        /// Get the authenticating user's friends.
        /// </summary>
        /// <remarks>
        /// This fails if client_credentials are used to perform the request.
        /// </remarks>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        public static Task<IEnumerable<OsuUserCard>> GetFriends(this OrbitClient client)
        {
            var request = new OsuUserFriendsRequest();
            return client.PerformAsync<IEnumerable<OsuUserCard>>(request);
        }
    }
}
