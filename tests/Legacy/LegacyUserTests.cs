// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using DragonFruit.Orbit.Api.Legacy.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Legacy
{
    [TestFixture]
    public class LegacyUserTests : OrbitApiTest
    {
        [TestCase("PaPaCurry", GameMode.Standard, 2990f)]
        [TestCase("4539503", GameMode.Taiko, 0f)]
        public void TestUserLookup(string id, GameMode? mode, float? minPP)
        {
            var user = Client.GetLegacyUser(id, mode);
            Assert.GreaterOrEqual(user.PP, minPP);
        }

        [TestCase("PaPaCurry", GameMode.Standard, 160f)]
        public void TestUserScoreRetrieval(string identifier, GameMode mode, float minPP)
        {
            var bestScores = Client.GetLegacyBestScores(identifier, mode);

            Assert.IsNotNull(bestScores);
            Assert.GreaterOrEqual(bestScores.Max(x => x.PP ?? 0), minPP);
        }
    }
}
