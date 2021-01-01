// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.User.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.User
{
    [TestFixture]
    public class OsuUserTests : OrbitApiTest
    {
        [TestCase(2u)]
        public void TestUserLookup(uint id, GameMode? mode = null)
        {
            Client.GetUser(id, mode);
        }

        [TestCase("PaPaCurry", 13723332u)]
        public void TestUserRedirectLookup(string username, uint id)
        {
            var user = Client.GetUser(username);
            Assert.AreEqual(id, user.Id);
        }
    }
}
