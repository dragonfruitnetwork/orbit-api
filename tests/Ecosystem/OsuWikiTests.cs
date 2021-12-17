// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Ecosystem.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Ecosystem
{
    [TestFixture]
    public class OsuWikiTests : OrbitApiTest
    {
        [TestCase("Grade", new[] { "rank" })]
        public async Task TestWiki(string path, params string[] expectedTags)
        {
            var wikiPage = await Client.GetWikiPage(path);
            Assert.IsTrue(expectedTags.All(x => wikiPage.Tags.Contains(x)));
        }
    }
}
