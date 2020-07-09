// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Orbit.API.Objects.News;
using DragonFruit.Orbit.API.Requests;

namespace DragonFruit.Orbit.API.Extensions
{
    public static class OsuNewsExtensions
    {
        /// <summary>
        /// Get the latest news, as listed on the official site
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <returns>A container with an <see cref="IEnumerable{T}"/> of posts and a cursor for searching</returns>
        public static OsuNewsContainer GetLatestNews(this OrbitClient client)
        {
            var request = new OsuNewsRequest();
            return client.Perform<OsuNewsContainer>(request);
        }
    }
}
