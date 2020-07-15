// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.API.Tests.Tests
{
    [TestFixture]
    public class NewsTests : OrbitTestBase
    {
        [Test]
        public void TestNews()
        {
            Client.GetLatestNews();
        }
    }
}
