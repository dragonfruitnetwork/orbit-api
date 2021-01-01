// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Ranking.Entities;
using DragonFruit.Orbit.Api.Ranking.Requests;

namespace DragonFruit.Orbit.Api.Ranking.Extensions
{
    public static class OsuSpotlightsExtensions
    {
        /// <summary>
        /// Get the list of all spotlight events
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        public static OsuSpotlightsContainer GetSpotlights<T>(this T client) where T : OrbitClient
        {
            var request = new OsuSpotlightsRequest();
            return client.Perform<OsuSpotlightsContainer>(request);
        }
    }
}
