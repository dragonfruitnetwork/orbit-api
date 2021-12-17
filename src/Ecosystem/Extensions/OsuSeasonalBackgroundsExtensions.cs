// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Ecosystem.Entities;
using DragonFruit.Orbit.Api.Ecosystem.Requests;

namespace DragonFruit.Orbit.Api.Ecosystem.Extensions
{
    public static class OsuSeasonalBackgroundsExtensions
    {
        /// <summary>
        /// Get the current seasonal backgrounds
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        public static Task<OsuSeasonalBackgroundCollection> GetSeasonalBackgrounds(this OrbitClient client)
        {
            return client.PerformAsync<OsuSeasonalBackgroundCollection>(new OsuSeasonalBackgroundsRequest());
        }
    }
}
