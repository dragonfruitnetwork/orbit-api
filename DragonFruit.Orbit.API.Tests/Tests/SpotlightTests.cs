// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using DragonFruit.Orbit.API.Extensions;
using DragonFruit.Orbit.API.Objects.Enums;
using NUnit.Framework;

namespace DragonFruit.Orbit.API.Tests.Tests
{
    [TestFixture]
    public class SpotlightTests : OrbitTestBase
    {
        [Test]
        public void TestSpotlights()
        {
            var spotlights = Client.GetSpotlights();
            _ = Client.GetSpotlightLeaderboard(GameMode.osu, spotlights.First().Id);
        }
    }
}
