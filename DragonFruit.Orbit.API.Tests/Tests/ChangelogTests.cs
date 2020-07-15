// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Extensions;
using DragonFruit.Orbit.API.Objects.Enums;
using NUnit.Framework;

namespace DragonFruit.Orbit.API.Tests.Tests
{
    [TestFixture]
    public class ChangelogTests : OrbitTestBase
    {
        [Test]
        public void TestChangelog()
        {
            _ = Client.GetChangelog();
        }

        [TestCase(OsuChangelogStream.Stable, "20200704")]
        [TestCase(OsuChangelogStream.Web, "2020.714.0")]
        public void TestSpecificChangelog(OsuChangelogStream stream, string version)
        {
            _ = Client.GetChangelog(stream, version);
        }
    }
}
