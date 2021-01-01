// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Linq;
using DragonFruit.Orbit.Api.Ranking.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Ranking
{
    [TestFixture]
    public class OsuSpotlightsTest : OrbitApiTest
    {
        [Test]
        public void TestSpotlights()
        {
            var spotlights = Client.GetSpotlights().Events.ToArray();

            Assert.IsTrue(spotlights.Single(x => x.Id == 82).EndDate == new DateTimeOffset(2013, 12, 15, 0, 0, 0, TimeSpan.Zero));
            Assert.IsTrue(spotlights.Single(x => x.Id == 271).ModeSpecific);
        }
    }
}
