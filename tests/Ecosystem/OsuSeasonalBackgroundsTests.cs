// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Ecosystem.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Ecosystem
{
    [TestFixture]
    public class OsuSeasonalBackgroundsTests : OrbitApiTest
    {
        [Test]
        public void TestSeasonalBackgrounds()
        {
            Client.GetSeasonalBackgrounds();
        }
    }
}
