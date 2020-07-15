// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Linq;
using DragonFruit.Orbit.API.Legacy.Objects;
using DragonFruit.Orbit.API.Legacy.Requests;
using DragonFruit.Orbit.API.Objects.Enums;
using NUnit.Framework;

namespace DragonFruit.Orbit.API.Tests.Legacy
{
    [TestFixture]
    public class LegacyBeatmapTests : OrbitTestBase
    {
        [TestCase("481570", BeatmapQueryType.MapsetId, 1138401)]
        [TestCase("1431578", BeatmapQueryType.MapId, 1431578)]
        [TestCase("A15B5F45402F57BD2B1C20DFEF246354", BeatmapQueryType.Hash, 1420861)]
        public void TestBeatmapLookup(string query, BeatmapQueryType type, int actualMapId)
        {
            var request = new LegacyBeatmapInfoRequest();

            switch (type)
            {
                case BeatmapQueryType.Hash:
                    request.MapHash = query;
                    break;

                case BeatmapQueryType.MapId:
                    request.BeatmapId = uint.Parse(query);
                    break;

                case BeatmapQueryType.MapsetId:
                    request.BeatmapsetId = uint.Parse(query);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            var result = Client.Perform<LegacyBeatmap>(request);
            Assert.True(result.Any(x => x.BeatmapID == actualMapId));
        }

        [TestCase(1822450u, OsuMods.None)]
        [TestCase(2039519u, OsuMods.Hidden)]
        public void TestBeatmapScoreLookup(uint mapId, OsuMods mods)
        {
            var request = new LegacyBeatmapScoresRequest(mapId, mods);
            Client.Perform<LegacyScore>(request);
        }
    }
}
