// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Legacy.Objects;
using DragonFruit.Orbit.API.Legacy.Requests;
using DragonFruit.Orbit.API.Objects.Enums;
using NUnit.Framework;

namespace DragonFruit.Orbit.API.Tests.Legacy
{
    [TestFixture]
    public class LegacyBeatmapScoreTests : OrbitTestBase
    {
        [TestCase(1822450u, OsuMods.None)]
        [TestCase(2039519u, OsuMods.Hidden)]
        public void TestBetamapScoreLookup(uint mapId, OsuMods mods)
        {
            var request = new LegacyBeatmapScoresRequest(mapId, mods);
            Client.Perform<LegacyScore>(request);
        }
    }
}
