// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Beatmaps.Enums;
using DragonFruit.Orbit.Api.Beatmaps.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Beatmaps
{
    [TestFixture]
    public class BeatmapTests : OrbitApiTest
    {
        [TestCase("74f9de6ff5a41bf011ac016e2a5374ff", 2601894u)]
        public async Task TestBeatmapLookupByHash(string hash, uint expectedId)
        {
            var mapInfo = await Client.GetBeatmapByHash(hash);

            Assert.IsNotNull(mapInfo);
            Assert.AreEqual(expectedId, mapInfo.Id);
        }

        [TestCase(2025942u, GameMode.Standard, 4498616u)]
        public async Task TestBeatmapScoreLookup(uint mapId, GameMode mode, uint expectedUser)
        {
            var globalBests = await Client.GetScores(mapId, mode, BeatmapLeaderboardType.Global);

            Assert.IsNull(globalBests.UserBest);
            Assert.IsNotNull(globalBests.Scores);
            Assert.IsNotNull(globalBests.Scores.SingleOrDefault(x => x.UserId == expectedUser));
        }
    }
}
