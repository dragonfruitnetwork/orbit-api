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

        public static OsuLeaderboardContainer<OsuCountryLeaderboardEntry> GetCountryRankings(this OrbitClient client, GameMode mode)
            => GetCountryRankings(client, mode, DefaultPage);

        public static OsuLeaderboardContainer<OsuPlayerLeaderboardEntry> GetPerformanceRankings(this OrbitClient client, GameMode mode)
            => GetPerformanceRankings(client, mode, DefaultPage);

        public static OsuLeaderboardContainer<OsuPlayerLeaderboardEntry> GetTotalRankedScoreRankings(this OrbitClient client, GameMode mode)
            => GetTotalRankedScoreRankings(client, mode, DefaultPage);

        #endregion

        public static OsuLeaderboardContainer<OsuCountryLeaderboardEntry> GetCountryRankings(this OrbitClient client, GameMode mode, uint page)
            => GetLeaderboard<OsuCountryLeaderboardEntry>(client, mode, OsuLeaderboardRankingType.Country, page);

        public static OsuLeaderboardContainer<OsuPlayerLeaderboardEntry> GetPerformanceRankings(this OrbitClient client, GameMode mode, uint page)
            => GetLeaderboard<OsuPlayerLeaderboardEntry>(client, mode, OsuLeaderboardRankingType.Country, page);

        public static OsuLeaderboardContainer<OsuPlayerLeaderboardEntry> GetTotalRankedScoreRankings(this OrbitClient client, GameMode mode, uint page)
            => GetLeaderboard<OsuPlayerLeaderboardEntry>(client, mode, OsuLeaderboardRankingType.Score, page);

        public static OsuSpotlightsLeaderboardContainer GetSpotlightLeaderboard(this OrbitClient client, GameMode mode, uint spotlightsId)
        {
            var request = new OsuSpotlightsLeaderboardRequest(mode) { SpotlightsId = spotlightsId };
            return client.Perform<OsuSpotlightsLeaderboardContainer>(request);
        }

        /// <summary>
        /// Generic method for getting most leaderboard types
        /// </summary>
        private static OsuLeaderboardContainer<T> GetLeaderboard<T>(this OrbitClient client, GameMode mode, OsuLeaderboardRankingType type, uint page) where T : class
        {
            var request = new OsuLeaderboardRequest(mode, type)
            {
                Page = page
            };

            return client.Perform<OsuLeaderboardContainer<T>>(request);
        }
    }
}
