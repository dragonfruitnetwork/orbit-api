// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Ecosystem.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Ecosystem
{
    [TestFixture]
    public class OsuChangelogTests : OrbitApiTest
    {
        [TestCase(ChangelogTarget.Lazer, "2020.1225.0", new[] { 10184u, 10190u })]
        public async Task TestTargetedChangelogs(ChangelogTarget target, string version, params uint[] expectedIds)
        {
            var release = await Client.GetChangelogEntry(target, version);

            var matchingIds = release.Entries.Where(x => x.Id.HasValue).Count(x => expectedIds.Contains(x.Id.Value));
            Assert.AreEqual(expectedIds.Length, matchingIds);
        }
    }
}
