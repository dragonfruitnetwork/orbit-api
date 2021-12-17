// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Orbit.Api.Legacy.Entities;
using DragonFruit.Orbit.Api.Legacy.Requests;

namespace DragonFruit.Orbit.Api.Legacy.Extensions
{
    public static class OsuLegacyUserScoreExtensions
    {
        /// <summary>
        /// Get a user's most recent performances
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="user">The <see cref="OsuLegacyUser"/> to get results for</param>
        /// <param name="mode">Optional mode to return scores for. Defaults to osu!standard</param>
        /// <param name="limit">Optional limit for the number of results. Max 50, Default 10.</param>
        public static IEnumerable<OsuLegacyScore> GetLegacyRecentScores<T>(this T client, OsuLegacyUser user, GameMode? mode = null, uint? limit = null)
            where T : ApiClient, ILegacyOrbitClient
        {
            return client.GetLegacyRecentScores(user.UserId.ToString(), mode, true, limit);
        }

        /// <summary>
        /// Get a user's most recent performances
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="user">The <see cref="OsuLegacyUser"/> to get results for</param>
        /// <param name="mode">Optional mode to return scores for. Defaults to osu!standard</param>
        /// <param name="limit">Optional limit for the number of results. Max 50, Default 10.</param>
        public static Task<IEnumerable<OsuLegacyScore>> GetLegacyRecentScoresAsync<T>(this T client, OsuLegacyUser user, GameMode? mode = null, uint? limit = null)
            where T : ApiClient, ILegacyOrbitClient
        {
            return client.GetLegacyRecentScoresAsync(user.UserId.ToString(), mode, true, limit);
        }

        /// <summary>
        /// Get a user's most recent performances
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="id">The id of the user to get results for</param>
        /// <param name="mode">Optional mode to return scores for. Defaults to osu!standard</param>
        /// <param name="isIdentifierUsername">Optional flag to help the server lookup a user. Set to true if the <see cref="id"/> is a username, false if not. null will allow the server to make it's own decision</param>
        /// <param name="limit">Optional limit for the number of results. Max 50, Default 10.</param>
        public static IEnumerable<OsuLegacyScore> GetLegacyRecentScores<T>(this T client, string id, GameMode? mode = null, bool? isIdentifierUsername = null, uint? limit = null)
            where T : ApiClient, ILegacyOrbitClient
        {
            var request = new OsuLegacyRecentScoresRequest(id)
            {
                Mode = mode,
                Limit = limit,
                IsIdentifierUsername = isIdentifierUsername
            };

            return client.Perform<IEnumerable<OsuLegacyScore>>(request);
        }

        /// <summary>
        /// Get a user's most recent performances
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="id">The id of the user to get results for</param>
        /// <param name="mode">Optional mode to return scores for. Defaults to osu!standard</param>
        /// <param name="isIdentifierUsername">Optional flag to help the server lookup a user. Set to true if the <see cref="id"/> is a username, false if not. null will allow the server to make it's own decision</param>
        /// <param name="limit">Optional limit for the number of results. Max 50, Default 10.</param>
        public static Task<IEnumerable<OsuLegacyScore>> GetLegacyRecentScoresAsync<T>(this T client, string id, GameMode? mode = null, bool? isIdentifierUsername = null, uint? limit = null)
            where T : ApiClient, ILegacyOrbitClient
        {
            var request = new OsuLegacyRecentScoresRequest(id)
            {
                Mode = mode,
                Limit = limit,
                IsIdentifierUsername = isIdentifierUsername
            };

            return client.PerformAsync<IEnumerable<OsuLegacyScore>>(request);
        }

        /// <summary>
        /// Get a user's best scores
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="user">The <see cref="OsuLegacyUser"/> to get results for</param>
        /// <param name="mode">Optional mode to return scores for. Defaults to osu!standard</param>
        /// <param name="limit">Optional limit for the number of results. Max 50, Default 10.</param>
        public static IEnumerable<OsuLegacyScore> GetLegacyBestScores<T>(this T client, OsuLegacyUser user, GameMode? mode = null, bool? isIdentifierUsername = null, uint? limit = null)
            where T : ApiClient, ILegacyOrbitClient
        {
            return client.GetLegacyBestScores(user.UserId.ToString(), mode, true, limit);
        }

        /// <summary>
        /// Get a user's best scores
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="user">The <see cref="OsuLegacyUser"/> to get results for</param>
        /// <param name="mode">Optional mode to return scores for. Defaults to osu!standard</param>
        /// <param name="limit">Optional limit for the number of results. Max 50, Default 10.</param>
        public static Task<IEnumerable<OsuLegacyScore>> GetLegacyBestScoresAsync<T>(this T client, OsuLegacyUser user, GameMode? mode = null, bool? isIdentifierUsername = null, uint? limit = null)
            where T : ApiClient, ILegacyOrbitClient
        {
            return client.GetLegacyBestScoresAsync(user.UserId.ToString(), mode, true, limit);
        }

        /// <summary>
        /// Get a user's best scores
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="id">The id of the user to get results for</param>
        /// <param name="mode">Optional mode to return scores for. Defaults to osu!standard</param>
        /// <param name="isIdentifierUsername">Optional flag to help the server lookup a user. Set to true if the <see cref="id"/> is a username, false if not. null will allow the server to make it's own decision</param>
        /// <param name="limit">Optional limit for the number of results. Max 50, Default 10.</param>
        public static IEnumerable<OsuLegacyScore> GetLegacyBestScores<T>(this T client, string id, GameMode? mode = null, bool? isIdentifierUsername = null, uint? limit = null)
            where T : ApiClient, ILegacyOrbitClient
        {
            var request = new OsuLegacyBestScoresRequest(id)
            {
                Mode = mode,
                Limit = limit,
                IsIdentifierUsername = isIdentifierUsername
            };

            return client.Perform<IEnumerable<OsuLegacyScore>>(request);
        }

        /// <summary>
        /// Get a user's best scores
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="id">The id of the user to get results for</param>
        /// <param name="mode">Optional mode to return scores for. Defaults to osu!standard</param>
        /// <param name="isIdentifierUsername">Optional flag to help the server lookup a user. Set to true if the <see cref="id"/> is a username, false if not. null will allow the server to make it's own decision</param>
        /// <param name="limit">Optional limit for the number of results. Max 50, Default 10.</param>
        public static Task<IEnumerable<OsuLegacyScore>> GetLegacyBestScoresAsync<T>(this T client, string id, GameMode? mode = null, bool? isIdentifierUsername = null, uint? limit = null)
            where T : ApiClient, ILegacyOrbitClient
        {
            var request = new OsuLegacyBestScoresRequest(id)
            {
                Mode = mode,
                Limit = limit,
                IsIdentifierUsername = isIdentifierUsername
            };

            return client.PerformAsync<IEnumerable<OsuLegacyScore>>(request);
        }
    }
}
