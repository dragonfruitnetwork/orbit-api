// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Extensions;
using DragonFruit.Orbit.API.Objects.Enums;
using NUnit.Framework;

namespace DragonFruit.Orbit.API.Tests.Tests
{
    [TestFixture]
    public class CommentsTests : OrbitTestBase
    {
        [Test]
        public void TestAllComments()
        {
            _ = Client.GetComments();
        }

        [TestCase(OsuCommentTarget.NewsPost, 800u)]
        [TestCase(OsuCommentTarget.NewsPost, 806u)]
        [TestCase(OsuCommentTarget.Beatmapset, 856070u)]
        [TestCase(OsuCommentTarget.Beatmapset, 1049950u)]
        [TestCase(OsuCommentTarget.Build, 5125u)]
        public void TestTargetedComment(OsuCommentTarget target, uint id)
        {
            _ = Client.GetCommentsFor(id, target);
            _ = Client.GetCommentsFor(id, target, 1);
        }

        [TestCase(1164239u)]
        [TestCase(1161314u)]
        public void TestComment(uint id)
        {
            _ = Client.GetComment(id);
        }
    }
}
