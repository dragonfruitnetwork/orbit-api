// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Ranking.Entities;
using DragonFruit.Orbit.Api.Ranking.Enums;
using DragonFruit.Orbit.Api.Ranking.Requests;

namespace DragonFruit.Orbit.Api.Ranking.Extensions
{
    public static class OsuLeaderboardExtensions
    {
        /// <summary>
        /// Get the leaderboard for a specific mode and criteria
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mode">The <see cref="GameMode"/> to get rankings for</param>
        /// <param name="type">The <see cref="LeaderboardType"/> to return</param>
        /// <param name="filter">Optional <see cref="LeaderboardFilterMode"/></param>
        /// <param name="country">Optional ISO3166-1 country code to filter users by</param>
        /// <param name="spotlight">Optional spotlight id to return entries for</param>
        /// <param name="variant"><see cref="LeaderboardVariant"/> for osu!mania 4/7 keys</param>
        /// <param name="last">Optional previous response that is used to get the next set</param>
        public static OsuLeaderboard GetLeaderboard<T>(this T client, GameMode mode, LeaderboardType type, LeaderboardFilterMode? filter = null, string country = null, uint? spotlight = null, LeaderboardVariant? variant = null, OsuLeaderboard last = null) where T : OrbitClient
        {
            var request = new OsuLeaderboardRequest
            {
                Mode = mode,
                Type = type,
                Filter = filter,
                Country = country,
                Spotlight = spotlight,
                Variant = variant,

                Cursor = last?.Cursor
            };

            return client.Perform<OsuLeaderboard>(request);
        }
    }
}
