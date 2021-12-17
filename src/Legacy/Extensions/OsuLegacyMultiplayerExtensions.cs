// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Orbit.Api.Legacy.Entities;
using DragonFruit.Orbit.Api.Legacy.Requests;

namespace DragonFruit.Orbit.Api.Legacy.Extensions
{
    // todo return null if the match doesn't exist
    public static class OsuLegacyMultiplayerExtensions
    {
        /// <summary>
        /// Get a osu! multiplayer match information from its id
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="matchId">The id of the match (ongoing or completed)</param>
        /// <returns>An <see cref="OsuLegacyMatch"/> container with information about the match</returns>
        public static Task<OsuLegacyMatch> GetLegacyMatchInfo<T>(this T client, uint matchId) where T :  ApiClient, ILegacyOrbitClient
        {
            var request = new OsuLegacyMatchRequest(matchId);
            return client.PerformAsync<OsuLegacyMatch>(request);
        }
    }
}
