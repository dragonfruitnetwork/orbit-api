// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using System.Threading.Tasks;
using DragonFruit.Orbit.Api.User.Enums;
using DragonFruit.Orbit.Api.User.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.User
{
    [TestFixture]
    public class OsuUserScoreTests : OrbitApiTest
    {
        [TestCase(13723332u)]
        public async Task TestBestScores(uint id)
        {
            var scores = await Client.GetUserScores(id, UserScoreType.Best);
            Assert.IsTrue(scores.Count() >= 5);
        }
    }
}
