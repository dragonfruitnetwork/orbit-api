// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Linq;
using DragonFruit.Orbit.API.Extensions;
using DragonFruit.Orbit.API.Objects.Enums;
using NUnit.Framework;

namespace DragonFruit.Orbit.API.Tests.Tests
{
    [TestFixture]
    public class BeatmapTests : OrbitTestBase
    {
        [TestCase("A15B5F45402F57BD2B1C20DFEF246354", BeatmapQueryType.Hash, 1420861u)]
        [TestCase("ZAQ - BRAVER (Yasaija 714) [Insane].osu", BeatmapQueryType.Filename, 1431578u)]
        [TestCase("1420861", BeatmapQueryType.MapId, 671199u)]
        [TestCase("676865", BeatmapQueryType.MapsetId, 1431578u)]
        public void TestBeatmapLookup(string query, BeatmapQueryType type, uint expectedResult)
        {
            switch (type)
            {
                case BeatmapQueryType.Hash:
                    var hashLookupResult = Client.GetBeatmapInfoByHash(query);
                    Assert.AreEqual(hashLookupResult.Id, expectedResult);
                    break;

                case BeatmapQueryType.Filename:
                    var filenameLookupResult = Client.GetBeatmapInfoByFilename(query);
                    Assert.AreEqual(filenameLookupResult.Id, expectedResult);
                    break;

                case BeatmapQueryType.MapId:
                    var mapIdLookupResult = Client.GetBeatmapsetInfoByMapId(uint.Parse(query));
                    Assert.AreEqual(mapIdLookupResult.Id, expectedResult);
                    break;

                case BeatmapQueryType.MapsetId:
                    var mapSetIdLookupResult = Client.GetBeatmapSetInfo(uint.Parse(query));
                    Assert.IsTrue(mapSetIdLookupResult.Beatmaps.Any(x => x.Id == expectedResult));
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        [TestCase(2038837u)]
        [TestCase(2039519u)]
        [TestCase(1431578u)]
        public void TestBeatmapScores(uint mapId)
        {
            Client.GetBeatmapScores(mapId, GameMode.Osu, BeatmapLeaderboardScope.Global);
        }

        [Test]
        public void TestBeatmapSearch()
        {
            //searches currently only work for oauth'd users (see https://github.com/ppy/osu-web/issues/6314)
            Client.SearchForBeatmapsets(string.Empty);
        }

        [Test]
        public void GetBeatmapEvents()
        {
            Client.GetBeatmapsetEvents();
        }
    }
}
