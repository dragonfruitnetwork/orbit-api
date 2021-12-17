// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Legacy.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Legacy
{
    [TestFixture]
    public class LegacyUserTests : OrbitApiTest
    {
        [TestCase("PaPaCurry", GameMode.Standard, 2990d)]
        [TestCase("4539503", GameMode.Taiko, 0d)]
        public async Task TestUserLookup(string id, GameMode? mode, double? minPP)
        {
            var user = await Client.GetLegacyUser(id, mode);
            Assert.GreaterOrEqual(user.PP, minPP);
        }

        [TestCase("PaPaCurry", GameMode.Standard, 160f)]
        public async Task TestUserScoreRetrieval(string identifier, GameMode mode, double minPP)
        {
            var bestScores = await Client.GetLegacyBestScores(identifier, mode);

            Assert.IsNotNull(bestScores);
            Assert.GreaterOrEqual(bestScores.Max(x => x.PP ?? 0), minPP);
        }
    }
}
