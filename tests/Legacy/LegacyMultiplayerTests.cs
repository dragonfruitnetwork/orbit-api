// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using DragonFruit.Orbit.Api.Legacy.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Legacy
{
    [TestFixture]
    public class LegacyMultiplayerTests : OrbitApiTest
    {
        [TestCase(64113963u, 336128537u, 16964514u)]
        public void TestMultiplayer(uint id, uint roundId, uint participatingUserId)
        {
            var matchInfo = Client.GetLegacyMatchInfo(id);
            var roundInfo = matchInfo.Rounds.SingleOrDefault(x => x.Id == roundId);

            Assert.IsNotNull(roundInfo);
            Assert.AreEqual(1, roundInfo.Scores.Count(x => x.UserId == participatingUserId));
        }
    }
}
