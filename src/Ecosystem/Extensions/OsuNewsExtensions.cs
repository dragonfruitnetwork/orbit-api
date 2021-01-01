// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Ecosystem.Entities;
using DragonFruit.Orbit.Api.Ecosystem.Requests;

namespace DragonFruit.Orbit.Api.Ecosystem.Extensions
{
    public static class OsuNewsExtensions
    {
        /// <summary>
        /// Gets latest news entries from the osu! site
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="limit">Optional limit that can be set</param>
        public static OsuNewsFeed GetNews<T>(this T client, uint? limit = null) where T : OrbitClient
        {
            var request = new OsuNewsRequest
            {
                Limit = limit
            };

            return client.Perform<OsuNewsFeed>(request);
        }

        /// <summary>
        /// Gets news posts that were published before the ones published in the <see cref="OsuNewsFeed"/> provided
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="last">The last <see cref="OsuNewsFeed"/> received. Used to get the previous values</param>
        /// <param name="limit">Optional limit that can be set</param>
        public static OsuNewsFeed GetNews<T>(this T client, OsuNewsFeed last, uint? limit = null) where T : OrbitClient
        {
            if (last?.Cursor == null)
            {
                return null;
            }

            var request = new OsuNewsRequest
            {
                Cursor = last.Cursor,
                Limit = limit
            };

            return client.Perform<OsuNewsFeed>(request);
        }
    }
}
