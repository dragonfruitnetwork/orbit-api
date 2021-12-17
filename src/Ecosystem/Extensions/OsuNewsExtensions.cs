// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Ecosystem.Entities;
using DragonFruit.Orbit.Api.Ecosystem.Requests;

namespace DragonFruit.Orbit.Api.Ecosystem.Extensions
{
    public static class OsuNewsExtensions
    {
        /// <summary>
        /// Gets news posts that were published before the ones published in the <see cref="OsuNewsFeed"/> provided
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="last">Optional last <see cref="OsuNewsFeed"/> received. Used to get the previous values</param>
        /// <param name="limit">Optional limit that can be set</param>
        public static Task<OsuNewsFeed> GetNews(this OrbitClient client, OsuNewsFeed last = null, uint? limit = null)
        {
            if (last is not null && last.Cursor is null)
            {
                return null;
            }

            var request = new OsuNewsRequest
            {
                Limit = limit,
                Cursor = last?.Cursor
            };

            return client.PerformAsync<OsuNewsFeed>(request);
        }
    }
}
