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
    public class OsuCommentsTests : OrbitApiTest
    {
        [Test]
        public async Task TestAllComments()
        {
            var comments = await Client.GetComments();
            var commentsPageTwo = await Client.GetComments(comments);

            var commentsFirstDate = comments.Comments.OrderBy(x => x.CreatedAt).First().CreatedAt;
            var commentsPageTwoLastDate = commentsPageTwo.Comments.OrderBy(x => x.CreatedAt).Last().CreatedAt;

            Assert.GreaterOrEqual(commentsFirstDate, commentsPageTwoLastDate);
        }

        [TestCase(1373758u, 5538u)]
        [TestCase(1377520u, 996208u)]
        public async Task TestSingleComment(uint id, uint targetId)
        {
            var comment = await Client.GetComment(id);

            Assert.IsTrue(comment.Comments.Any(x => x.CommentableId == targetId));
        }

        [TestCase(CommentableType.NewsPost, 884u, 1377532u)]
        [TestCase(CommentableType.ChangelogRelease, 5522u, 1375660u)]
        public async Task TestCommentableLookup(CommentableType type, uint typeId, uint expectedCommentId)
        {
            var comments = await Client.GetComments(type, typeId);
            Assert.IsTrue(comments.Comments.Select(x => x.Id).Contains(expectedCommentId));
        }
    }
}
