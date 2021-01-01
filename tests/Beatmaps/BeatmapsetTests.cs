// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using DragonFruit.Orbit.Api.Beatmaps.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Beatmaps
{
    [TestFixture]
    public class BeatmapsetTests : OrbitApiTest
    {
        [TestCase(1312793u, 2720745u)]
        public void TestBeatmapset(uint mapsetId, uint childMapId)
        {
            var mapset = Client.GetBeatmapset(mapsetId);
            Assert.IsNotNull(mapset.Maps.SingleOrDefault(x => x.Id == childMapId));
        }
    }
}
