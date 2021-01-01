// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using DragonFruit.Orbit.Api.User.Enums;
using DragonFruit.Orbit.Api.User.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.User
{
    [TestFixture]
    public class OsuUserScoreTests : OrbitApiTest
    {
        [TestCase(13723332u)]
        public void TestBestScores(uint id)
        {
            var scores = Client.GetUserScores(id, UserScoreType.Best);
            Assert.IsTrue(scores.Count() >= 5);
        }
    }
}
