// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Orbit.Api.Legacy.Entities;
using DragonFruit.Orbit.Api.Legacy.Enums;
using DragonFruit.Orbit.Api.Legacy.Requests;

namespace DragonFruit.Orbit.Api.Legacy.Extensions
{
    public static class OsuLegacyScoreExtensions
    {
        /// <summary>
        /// Get the best scores (globally) for a map
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mapId">The map id to retrieve scores for</param>
        /// <param name="mode">The <see cref="GameMode"/> to retrieve scores for</param>
        /// <param name="limit">Optional limit for number of scores to return</param>
        /// <returns>Collection of scores</returns>
        public static Task<IEnumerable<OsuLegacyScore>> GetLegacyBeatmapScores<T>(this T client, uint mapId, GameMode? mode = null, uint? limit = null) where T : ApiClient, ILegacyOrbitClient
        {
            var request = new OsuLegacyBeatmapScoresRequest
            {
                BeatmapId = mapId,
                Mode = mode,
                Limit = limit
            };

            return client.PerformAsync<IEnumerable<OsuLegacyScore>>(request);
        }

        /// <summary>
        /// Get a replay from a username and map id
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mapId">The id of the map the user played</param>
        /// <param name="identifier">The username or id of the player</param>
        /// <param name="isUsername">Optional switch to tell the server the <see cref="identifier"/> is a username</param>
        /// <param name="mode">The game mode the map was played in</param>
        /// <param name="mods">The mods the map was played with</param>
        /// <returns>Container for the Base64 encoded replay. This is not the .osr file, but just the input data (key/mouse)</returns>
        public static Task<OsuLegacyReplayContent> GetBeatmapReplay<T>(this T client, uint mapId, string identifier, GameMode mode, LegacyMods? mods = null, bool? isUsername = null)
            where T : ApiClient, ILegacyOrbitClient
        {
            var request = new OsuLegacyReplayRequest
            {
                BeatmapId = mapId,
                UserIdentifier = identifier,
                IsIdentifierUsername = isUsername,
                Mods = mods,
                Mode = mode
            };

            return client.PerformAsync<OsuLegacyReplayContent>(request);
        }

        /// <summary>
        /// Get a replay from a username and map id
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="scoreId">The id of the score</param>
        /// <returns>Container for the Base64 encoded replay. This is not the .osr file, but just the input data (key/mouse)</returns>
        public static Task<OsuLegacyReplayContent> GetBeatmapReplay<T>(this T client, ulong scoreId) where T : ApiClient, ILegacyOrbitClient
        {
            var request = new OsuLegacyReplayRequest
            {
                ScoreId = scoreId
            };

            return client.PerformAsync<OsuLegacyReplayContent>(request);
        }
    }
}
