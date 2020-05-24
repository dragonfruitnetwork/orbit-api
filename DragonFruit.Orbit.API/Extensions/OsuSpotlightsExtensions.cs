// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Orbit.API.Objects.Spotlights;
using DragonFruit.Orbit.API.Requests;

namespace DragonFruit.Orbit.API.Extensions
{
    public static class OsuSpotlightsExtensions
    {
        /// <summary>
        /// Get the osu!Spotlights info (name, date, etc.)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        public static IEnumerable<OsuSpotlightEntry> GetSpotlights(this OrbitClient client)
        {
            var request = new OsuSpotlightsRequest();
            return client.Perform<OsuSpotlightsInfoContainer>(request).Spotlights;
        }
    }
}
