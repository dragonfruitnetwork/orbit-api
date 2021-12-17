// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using System.Threading.Tasks;
using DragonFruit.Orbit.Api.User.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.User
{
    [TestFixture]
    public class OsuUserKudosuTests : OrbitApiTest
    {
        [TestCase(2u, 15u)]
        public async Task TestKudosuHistory(uint id, uint minEntries)
        {
            var history = await Client.GetKudosuHistory(id);
            Assert.IsTrue(history.Count() >= minEntries);
        }
    }
}
