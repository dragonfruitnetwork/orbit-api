// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using DragonFruit.Orbit.API.Extensions;
using DragonFruit.Orbit.API.Objects.Enums;
using NUnit.Framework;

namespace DragonFruit.Orbit.API.Tests.Tests
{
    [TestFixture]
    public class UserTests : OrbitTestBase
    {
        [TestCase("peppy")]
        [TestCase("13723332")]
        public void TestUserLookup(string identifier)
        {
            _ = Client.GetUser(identifier);
        }

        [TestCase("13723332")]
        public void TestUserModeLookup(string identifier)
        {
            _ = Client.GetUser(identifier, GameMode.Taiko);
        }

        [TestCase(13723332u)]
        public void TestUserRecentActivity(uint userId)
        {
            _ = Client.GetRecentActivity(userId);
        }

        [TestCase(13723332u)]
        public void TestUserScores(uint userId)
        {
            var bests = Client.GetUserScores(userId, OsuUserScoreType.Best);
            Assert.True(bests.Count() >= 10);

            _ = Client.GetUserScores(userId, GameMode.osu, OsuUserScoreType.Recent, true);
        }

        [TestCase(2u)]
        public void TestUserKudosu(uint userId)
        {
            _ = Client.GetKudosuHistory(userId);
            _ = Client.GetKudosuHistory(userId, 1);
        }

        [TestCase(4452992u)]
        public void TestUserBeatmaps(uint userId)
        {
            _ = Client.GetUserBeatmapsets(userId, OsuUserBeatmapsetStatus.RankedAndApproved);
            _ = Client.GetUserBeatmapsets(userId, OsuUserBeatmapsetStatus.RankedAndApproved, 1);
        }
    }
}
