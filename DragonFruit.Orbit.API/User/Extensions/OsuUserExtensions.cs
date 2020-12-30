// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Orbit.Api.Beatmaps.Entities;
using DragonFruit.Orbit.Api.User.Entities;
using DragonFruit.Orbit.Api.User.Enums;
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
        /// Get a user's published maps
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/></param>
        /// <param name="id">The id of the user</param>
        /// <param name="type">The <see cref="UserBeatmapType"/> to filter responses by</param>
        /// <param name="limit">Optional limit to cap responses</param>
        /// <param name="page">Optional page number to fetch reliant on the <see cref="limit"/></param>
        public static IEnumerable<OsuBeatmapset> GetUserMaps<T>(this T client, uint id, UserBeatmapType type, uint? limit = null, uint? page = null) where T : OrbitClient
        {
            var request = new OsuUserBeatmapsRequest(id, type)
            {
                Limit = limit,
                Page = page ?? 0
            };

            return client.Perform<IEnumerable<OsuBeatmapset>>(request);
        }
    }
}
