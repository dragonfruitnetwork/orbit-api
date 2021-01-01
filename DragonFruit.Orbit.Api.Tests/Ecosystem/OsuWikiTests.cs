// Orbit API Copyright 2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Linq;
using DragonFruit.Orbit.Api.Ecosystem.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests.Ecosystem
{
    [TestFixture]
    public class OsuWikiTests : OrbitApiTest
    {
        [TestCase("Grade", new[] { "rank" })]
        public void TestWiki(string path, params string[] expectedTags)
        {
            var wikiPage = Client.GetWikiPage(path);
            Assert.IsTrue(expectedTags.All(x => wikiPage.Tags.Contains(x)));
        }
    }
}
