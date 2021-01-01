// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Legacy.Entities;
using DragonFruit.Orbit.Api.Legacy.Requests;

namespace DragonFruit.Orbit.Api.Legacy.Extensions
{
    public static class OsuLegacyMultiplayerExtensions
    {
        /// <summary>
        /// Get a osu! multiplayer match information from it's id
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="matchId">The id of the match (ongoing or completed)</param>
        /// <returns>An <see cref="OsuLegacyMatch"/> container with information about the match, todo or null if it doesn't exist</returns>
        public static OsuLegacyMatch GetLegacyMatchInfo<T>(this T client, uint matchId) where T : OrbitClient
        {
            var request = new OsuLegacyMatchRequest(matchId);
            return client.Perform<OsuLegacyMatch>(request);
        }
    }
}
