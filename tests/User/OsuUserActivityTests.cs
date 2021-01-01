// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using DragonFruit.Orbit.Api.User.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.User
{
    [TestFixture]
    public class OsuUserActivityTests : OrbitApiTest
    {
        [TestCase(13723332u)]
        public void TestUserActivity(uint id)
        {
            var activity = Client.GetUserActivity(id);
            Assert.AreEqual(15, activity.Count());
        }
    }
}
