// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Linq;
using DragonFruit.Orbit.Api.Ranking.Entities;
using DragonFruit.Orbit.Api.Ranking.Enums;
using DragonFruit.Orbit.Api.Ranking.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Ranking
{
    [TestFixture]
    public class OsuLeaderboardTest : OrbitApiTest
    {
        [Test]
        public void TestInvalidLeaderboard()
        {
            Assert.Throws<NotSupportedException>(() => Client.GetLeaderboard(GameMode.Standard, LeaderboardType.Country));
        }

        [Test]
        public void TestCountryLeaderboard()
        {
            var countries = Client.GetCountryLeaderboard(GameMode.Standard);
            Assert.IsTrue(countries.Ranking.First().Code == "US");
        }

        [TestCase(GameMode.Standard, LeaderboardType.Performance, 4504101u)]
        [TestCase(GameMode.Taiko, LeaderboardType.Score, 3802922u, 2u)]
        public void TestLeaderboard(GameMode mode, LeaderboardType type, uint expectedUser, uint pages = 1)
        {
            OsuUserLeaderboard leaderboard = null;

            do
            {
                leaderboard = Client.GetLeaderboard(mode, type, last: leaderboard);
                pages--;
            } while (pages > 0);

            Assert.IsTrue(leaderboard.Ranking.Select(x => x.User?.Id).Contains(expectedUser));
        }
    }
}
