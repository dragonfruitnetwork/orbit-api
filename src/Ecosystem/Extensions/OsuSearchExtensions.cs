﻿// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Ecosystem.Entities;
using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Ecosystem.Requests;

namespace DragonFruit.Orbit.Api.Ecosystem.Extensions
{
    public static class OsuSearchExtensions
    {
        /// <summary>
        /// Performs a site-wide search (either for wiki pages or users)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="query">The search query to return results for</param>
        /// <param name="target">The <see cref="SearchTarget"/> that determines what is returned.</param>
        /// <param name="page">Optional page (only used when the <see cref="SearchTarget"/> is not all)</param>
        /// <returns>
        /// The search results. Note only the first 100 users from a search can be accessed.
        /// </returns>
        public static Task<OsuSearchResponse> Search(this OrbitClient client, string query, SearchTarget? target = null, int? page = null)
        {
            var request = new OsuSearchRequest(query)
            {
                Target = target,
                Page = page
            };

            return client.PerformAsync<OsuSearchResponse>(request);
        }
    }
}
