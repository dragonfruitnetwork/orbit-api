// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using System.Threading.Tasks;
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
        public static Task<IEnumerable<OsuBeatmapset>> GetUserMaps(this OrbitClient client, OsuUserCard user, UserBeatmapType type, uint? limit = null, uint page = 0)
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
        public static Task<IEnumerable<OsuBeatmapset>> GetUserMaps(this OrbitClient client, uint id, UserBeatmapType type, uint? limit = null, uint page = 0)
        {
            var request = new OsuUserBeatmapsRequest(id, type)
            {
                Limit = limit,
                Page = page
            };

            return client.PerformAsync<IEnumerable<OsuBeatmapset>>(request);
        }
    }
}
