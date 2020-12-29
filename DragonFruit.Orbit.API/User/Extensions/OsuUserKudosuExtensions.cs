// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
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
        public static IEnumerable<OsuKudosuHistory> GetKudosuHistory<T>(this T client, OsuUserCard user, uint? page = null, uint? limit = null) where T : OrbitClient
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
        public static IEnumerable<OsuKudosuHistory> GetKudosuHistory<T>(this T client, uint id, uint? page = null, uint? limit = null) where T : OrbitClient
        {
            var request = new OsuUserKudosuRequest(id)
            {
                Page = page ?? 0,
                Limit = limit
            };

            return client.Perform<IEnumerable<OsuKudosuHistory>>(request);
        }
    }
}
