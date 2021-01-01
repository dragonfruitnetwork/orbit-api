// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using DragonFruit.Orbit.Api.Ecosystem.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Ecosystem
{
    [TestFixture]
    public class OsuNewsTests : OrbitApiTest
    {
        [Test]
        public void TestNews()
        {
            var firstFeed = Client.GetNews();
            var secondFeed = Client.GetNews(firstFeed);

            var earliestDateInFirstFeed = firstFeed.Entries.OrderByDescending(x => x.PublishedAt).Last().PublishedAt;
            var latestDateInSecondFeed = secondFeed.Entries.OrderByDescending(x => x.PublishedAt).First().PublishedAt;

            Assert.IsTrue(earliestDateInFirstFeed > latestDateInSecondFeed);
        }
    }
}
