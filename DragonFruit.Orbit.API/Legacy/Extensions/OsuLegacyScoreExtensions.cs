// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
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
        /// <param name="mode">The <see cref="LegacyMode"/> to retrieve scores for</param>
        /// <param name="limit">Optional limit for number of scores to return</param>
        /// <returns>Collection of scores</returns>
        public static IEnumerable<OsuLegacyHighScore> GetLegacyBeatmapScores<T>(this T client, uint mapId, LegacyMode? mode = null, uint? limit = null) where T : OrbitClient
        {
            var request = new OsuLegacyBeatmapScoresRequest
            {
                BeatmapId = mapId,
                Mode = mode,
                Limit = limit
            };

            return client.Perform<OsuLegacyHighScore>(request);
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
        public static OsuLegacyReplayContent GetBeatmapReplay<T>(this T client, uint mapId, string identifier, LegacyMode mode, LegacyMods? mods = null, bool? isUsername = null) where T : OrbitClient
        {
            var request = new OsuLegacyReplayRequest
            {
                BeatmapId = mapId,
                UserIdentifier = identifier,
                IsIdentifierUsername = isUsername,
                Mods = mods,
                Mode = mode
            };

            return client.Perform<OsuLegacyReplayContent>((OsuLegacyRequest)request);
        }

        /// <summary>
        /// Get a replay from a username and map id
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="scoreId">The id of the score</param>
        /// <returns>Container for the Base64 encoded replay. This is not the .osr file, but just the input data (key/mouse)</returns>
        public static OsuLegacyReplayContent GetBeatmapReplay<T>(this T client, ulong scoreId) where T : OrbitClient
        {
            var request = new OsuLegacyReplayRequest
            {
                ScoreId = scoreId
            };

            return client.Perform<OsuLegacyReplayContent>((OsuLegacyRequest)request);
        }
    }
}
