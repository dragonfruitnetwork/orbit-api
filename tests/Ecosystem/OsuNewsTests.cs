// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Ecosystem.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Ecosystem
{
    [TestFixture]
    public class OsuNewsTests : OrbitApiTest
    {
        [Test]
        public async Task TestNews()
        {
            var firstFeed = await Client.GetNews();
            var secondFeed = await Client.GetNews(firstFeed);

            var earliestDateInFirstFeed = firstFeed.Entries.OrderByDescending(x => x.PublishedAt).Last().PublishedAt;
            var latestDateInSecondFeed = secondFeed.Entries.OrderByDescending(x => x.PublishedAt).First().PublishedAt;

            Assert.IsTrue(earliestDateInFirstFeed > latestDateInSecondFeed);
        }
    }
}
