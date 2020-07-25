// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using DragonFruit.Orbit.API.Legacy.Objects;
using DragonFruit.Orbit.API.Legacy.Requests;
using DragonFruit.Orbit.API.Objects.Enums;
using NUnit.Framework;

namespace DragonFruit.Orbit.API.Tests.Legacy
{
    [TestFixture]
    public class LegacyUserTests : OrbitTestBase
    {
        [TestCase("2", true)]
        [TestCase("papacurry", false)]
        public void TestUserLookup(string query, bool isId)
        {
            var request = new LegacyUserRequest(query, null);
            Assert.IsTrue(Client.Perform<LegacyOsuUser>(request).Count() == 1);

            var specificModeRequest = new LegacyUserRequest(query, GameMode.Taiko);
            Assert.IsTrue(Client.Perform<LegacyOsuUser>(specificModeRequest).Count() == 1);
        }

        [TestCase(15645406u, GameMode.osu, 5u)]
        [TestCase(13723332u, GameMode.osu, 30u)]
        public void TestUserBestScores(uint id, GameMode mode, uint limit)
        {
            var request = new LegacyUserBestPerformancesRequest(id, mode)
            {
                Limit = limit
            };

            var scores = Client.Perform<LegacyScore>(request);
            Assert.IsTrue(scores.Count() <= limit);
        }

        [TestCase(13723332u, GameMode.osu)]
        public void TestUserRecentScores(uint id, GameMode mode)
        {
            var request = new LegacyUserRecentPerformancesRequest(id, mode);
            Client.Perform<LegacyScore>(request);
        }
    }
}
