// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Orbit.Api.Beatmaps.Entities;
using DragonFruit.Orbit.Api.User.Entities;
using DragonFruit.Orbit.Api.User.Enums;
using DragonFruit.Orbit.Api.User.Requests;

namespace DragonFruit.Orbit.Api.User.Extensions
{
    public static class OsuUserMapsExtensions
    {
        /// <summary>
        /// Get a user's published maps
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/></param>
        /// <param name="user">The user to get maps by</param>
        /// <param name="type">The <see cref="UserBeatmapType"/> to filter responses by</param>
        /// <param name="limit">Optional limit to cap responses</param>
        /// <param name="page">Optional page number to fetch reliant on the <see cref="limit"/></param>
        public static IEnumerable<OsuBeatmapset> GetUserMaps<T>(this T client, OsuUserCard user, UserBeatmapType type, uint? limit = null, uint? page = null) where T : OrbitClient
        {
            return client.GetUserMaps(user.Id, type, limit, page);
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
