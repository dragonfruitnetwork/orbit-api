// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Ecosystem.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Ecosystem
{
    [TestFixture]
    public class OsuSearchTests : OrbitApiTest
    {
        [TestCase("papacurry", 13723332u)]
        public void TestUserSearch(string query, uint expectedId)
        {
            var results = Client.Search(query, SearchTarget.User);

            Assert.IsNotNull(results.Users);
            Assert.IsTrue(results.Users.Items.Select(x => x.Id).Contains(expectedId));
        }
    }
}
