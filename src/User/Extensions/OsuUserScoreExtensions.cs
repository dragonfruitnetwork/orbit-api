// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Orbit.Api.Ranking.Entities;
using DragonFruit.Orbit.Api.User.Entities;
using DragonFruit.Orbit.Api.User.Enums;
using DragonFruit.Orbit.Api.User.Requests;

namespace DragonFruit.Orbit.Api.User.Extensions
{
    public static class OsuUserScoreExtensions
    {
        /// <summary>
        /// Get scores for the provided user
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="user">The user to get scores for</param>
        /// <param name="type">The <see cref="UserScoreType"/> to return</param>
        /// <param name="mode">Optional mode to filter results by</param>
        /// <param name="page">Optional page to get (based on limit)</param>
        /// <param name="limit">Optional maximum entries to return </param>
        /// <param name="includeFails">Whether to include fails when requesting recent scores</param>
        public static IEnumerable<OsuScore> GetUserScores<T>(this T client, OsuUserCard user, UserScoreType type, GameMode? mode = null, uint page = 0, uint? limit = null, bool includeFails = false)
            where T : OrbitClient
        {
            return client.GetUserScores(user.Id, type, mode, page, limit, includeFails);
        }

        /// <summary>
        /// Get scores for the provided user
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="id">The id of the user</param>
        /// <param name="type">The <see cref="UserScoreType"/> to return</param>
        /// <param name="mode">Optional mode to filter results by</param>
        /// <param name="page">Optional page to get (based on limit)</param>
        /// <param name="limit">Optional maximum entries to return </param>
        /// <param name="includeFails">Whether to include fails when requesting recent scores</param>
        public static IEnumerable<OsuScore> GetUserScores<T>(this T client, uint id, UserScoreType type, GameMode? mode = null, uint page = 0, uint? limit = null, bool includeFails = false)
            where T : OrbitClient
        {
            var request = new OsuUserScoresRequest(id, type)
            {
                Mode = mode,
                IncludeFails = includeFails,
                Page = page,
                Limit = limit
            };

            return client.Perform<IEnumerable<OsuScore>>(request);
        }
    }
}
