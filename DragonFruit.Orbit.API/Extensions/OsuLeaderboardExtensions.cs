// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.Leaderboard;
using DragonFruit.Orbit.API.Objects.Spotlights;
using DragonFruit.Orbit.API.Requests;

namespace DragonFruit.Orbit.API.Extensions
{
    public static class OsuLeaderboardExtensions
    {
        private const int DefaultPage = 1; //page 0 and 1 are the same, so the default page is page one

        #region Page-less

        /// <summary>
        /// List the first page of the osu! countries leaderboard
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mode">The <see cref="GameMode"/> to load rankings for</param>
        public static OsuLeaderboardContainer<OsuCountryLeaderboardEntry> GetCountryRankings<T>(this T client, GameMode mode) where T : OrbitClient
            => GetCountryRankings(client, mode, DefaultPage);

        /// <summary>
        /// List the first page of the osu! top performing players leaderboard
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mode">The <see cref="GameMode"/> to load rankings for</param>
        public static OsuLeaderboardContainer<OsuPlayerLeaderboardEntry> GetPerformanceRankings<T>(this T client, GameMode mode) where T : OrbitClient
            => GetPerformanceRankings(client, mode, DefaultPage);

        /// <summary>
        /// List the first page of the osu! highest scores leaderboard
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mode">The <see cref="GameMode"/> to load rankings for</param>
        public static OsuLeaderboardContainer<OsuPlayerLeaderboardEntry> GetTotalRankedScoreRankings<T>(this T client, GameMode mode) where T : OrbitClient
            => GetTotalRankedScoreRankings(client, mode, DefaultPage);

        #endregion

        /// <summary>
        /// List the specified page of the osu! countries leaderboard
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mode">The <see cref="GameMode"/> to load rankings for</param>
        public static OsuLeaderboardContainer<OsuCountryLeaderboardEntry> GetCountryRankings<T>(this T client, GameMode mode, uint page) where T : OrbitClient
            => GetLeaderboard<OsuCountryLeaderboardEntry, T>(client, mode, OsuLeaderboardRankingType.Country, page);

        /// <summary>
        /// List the specified page of the osu! top performing players leaderboard
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mode">The <see cref="GameMode"/> to load rankings for</param>
        public static OsuLeaderboardContainer<OsuPlayerLeaderboardEntry> GetPerformanceRankings<T>(this T client, GameMode mode, uint page) where T : OrbitClient
            => GetLeaderboard<OsuPlayerLeaderboardEntry, T>(client, mode, OsuLeaderboardRankingType.Country, page);

        /// <summary>
        /// List the specified page of the osu! top performances leaderboard
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mode">The <see cref="GameMode"/> to load rankings for</param>
        public static OsuLeaderboardContainer<OsuPlayerLeaderboardEntry> GetTotalRankedScoreRankings<T>(this T client, GameMode mode, uint page) where T : OrbitClient
            => GetLeaderboard<OsuPlayerLeaderboardEntry, T>(client, mode, OsuLeaderboardRankingType.Score, page);

        /// <summary>
        /// Get the leaderboard for a specified osu!Spotlights leaderboard
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="mode">The <see cref="GameMode"/> to load rankings for</param>
        public static OsuSpotlightsLeaderboardContainer GetSpotlightLeaderboard<T>(this T client, GameMode mode, uint spotlightsId) where T : OrbitClient
        {
            var request = new OsuSpotlightsLeaderboardRequest(mode, spotlightsId);
            return client.Perform<OsuSpotlightsLeaderboardContainer>(request);
        }

        /// <summary>
        /// Generic method for getting most leaderboard types
        /// </summary>
        private static OsuLeaderboardContainer<T> GetLeaderboard<T, TClient>(this TClient client, GameMode mode, OsuLeaderboardRankingType type, uint page)
            where T : class
            where TClient : OrbitClient
        {
            var request = new OsuLeaderboardRequest(mode, type)
            {
                Page = page
            };

            return client.Perform<OsuLeaderboardContainer<T>>(request);
        }
    }
}
