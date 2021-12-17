// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using System.Threading.Tasks;
using DragonFruit.Orbit.Api.User.Entities;
using DragonFruit.Orbit.Api.User.Requests;

namespace DragonFruit.Orbit.Api.User.Extensions
{
    public static class OsuUserKudosuExtensions
    {
        /// <summary>
        /// Get the specified user's kudosu history
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="user">The user to get the history for</param>
        /// <param name="page">Optional page number to return entries for</param>
        /// <param name="limit">Optional limit to cap responses. Make sure this is equal to the max or lower otherwise pagination will fail</param>
        public static Task<IEnumerable<OsuKudosuHistory>> GetKudosuHistory(this OrbitClient client, OsuUserCard user, uint page = 0, uint? limit = null)
        {
            return client.GetKudosuHistory(user.Id, page, limit);
        }

        /// <summary>
        /// Get the specified user's kudosu history
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="id">The user id to get the history for</param>
        /// <param name="page">Optional page number to return entries for</param>
        /// <param name="limit">Optional limit to cap responses. Make sure this is equal to the max or lower otherwise pagination will fail</param>
        public static Task<IEnumerable<OsuKudosuHistory>> GetKudosuHistory(this OrbitClient client, uint id, uint page = 0, uint? limit = null)
        {
            var request = new OsuUserKudosuRequest(id)
            {
                Page = page,
                Limit = limit
            };

            return client.PerformAsync<IEnumerable<OsuKudosuHistory>>(request);
        }
    }
}
