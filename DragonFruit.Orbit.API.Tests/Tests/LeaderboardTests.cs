// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Extensions;
using DragonFruit.Orbit.API.Objects.Enums;
using NUnit.Framework;

namespace DragonFruit.Orbit.API.Tests.Tests
{
    [TestFixture]
    public class LeaderboardTests : OrbitTestBase
    {
        [Test]
        public void TestCountryLeaderboard()
        {
            _ = Client.GetCountryRankings(GameMode.osu);
            _ = Client.GetCountryRankings(GameMode.osu, 2);
        }

        [Test]
        public void TestPerformanceLeaderboard()
        {
            _ = Client.GetPerformanceRankings(GameMode.Taiko);
            _ = Client.GetCountryRankings(GameMode.osu, 2);
        }
    }
}
