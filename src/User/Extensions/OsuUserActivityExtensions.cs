﻿// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using System.Threading.Tasks;
using DragonFruit.Orbit.Api.User.Entities;
using DragonFruit.Orbit.Api.User.Requests;

namespace DragonFruit.Orbit.Api.User.Extensions
{
    public static class OsuUserActivityExtensions
    {
        /// <summary>
        /// Gets the user's recent in-game activity
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="user">The user to lookup</param>
        /// <param name="page">Optional page number to return entries for</param>
        /// <param name="limit">Optional limit to cap responses. Make sure this is equal to the max or lower otherwise pagination will fail</param>
        public static Task<IEnumerable<OsuRecentActivity>> GetUserActivity(this OrbitClient client, OsuUserCard user, uint page = 0, uint? limit = null)
        {
            return client.GetUserActivity(user.Id, page, limit);
        }

        /// <summary>
        /// Gets the user's recent in-game activity
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="id">The id of the user</param>
        /// <param name="page">Optional page number to return entries for</param>
        /// <param name="limit">Optional limit to cap responses. Make sure this is equal to the max or lower otherwise pagination will fail</param>
        public static Task<IEnumerable<OsuRecentActivity>> GetUserActivity(this OrbitClient client, uint id, uint page = 0, uint? limit = null)
        {
            var request = new OsuUserRecentActivityRequest(id)
            {
                Page = page,
                Limit = limit
            };

            return client.PerformAsync<IEnumerable<OsuRecentActivity>>(request);
        }
    }
}
