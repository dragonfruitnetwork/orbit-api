// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;
using DragonFruit.Orbit.API.Objects.Comments;
using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Requests;

namespace DragonFruit.Orbit.API.Extensions
{
    public static class OsuCommentsExtensions
    {
        /// <summary>
        /// Get the latest comments posted on the osu! website for any commentable entity
        /// </summary>
        /// <param name="client">The <see cref="ApiClient"/> to use</param>
        /// <returns>A container with the comments, cursor and users concerned</returns>
        public static OsuCommentsContainer GetComments(this ApiClient client)
        {
            return client.GetComments(1);
        }

        /// <summary>
        /// Get a the first page of comments posted on the osu! website for a specific commentable entity
        /// </summary>
        /// <param name="client">The <see cref="ApiClient"/> to use</param>
        /// <param name="target">Id of the thing to get comments for (the beatmapset id, news post id, etc.)</param>
        /// <param name="targetType">The type of item the <see cref="target"/> is</param>
        /// <returns>A container with the comments and users concerned</returns>
        public static OsuCommentsContainer GetCommentsFor(this ApiClient client, uint target, OsuCommentTarget targetType)
        {
            return GetCommentsFor(client, target, targetType, 0);
        }

        /// <summary>
        /// Get a specific page of comments posted on the osu! website for a specific commentable entity
        /// </summary>
        /// <param name="client">The <see cref="ApiClient"/> to use</param>
        /// <param name="target">Id of the thing to get comments for (the beatmapset id, news post id, etc.)</param>
        /// <param name="targetType">The type of item the <see cref="target"/> is</param>
        /// <returns>A container with the comments and users concerned</returns>
        public static OsuCommentsContainer GetCommentsFor(this ApiClient client, uint target, OsuCommentTarget targetType, uint page)
        {
            var request = new OsuCommentsRequest(target, targetType, page);
            return client.Perform<OsuCommentsContainer>(request);
        }

        /// <summary>
        /// Get a specific page of comments posted on the osu! website for any commentable entity
        /// </summary>
        /// <param name="client">The <see cref="ApiClient"/> to use</param>
        /// <param name="page">The page number to return</param>
        /// <returns>A container with the comments, cursor and users concerned</returns>
        public static OsuCommentsContainer GetComments(this ApiClient client, uint page)
        {
            var request = new OsuCommentsRequest
            {
                Page = page
            };

            return client.Perform<OsuCommentsContainer>(request);
        }

        /// <summary>
        /// Get a specific comment, and it's child comments (upto 2 levels)
        /// </summary>
        /// <param name="client">The <see cref="ApiClient"/> to use</param>
        /// <param name="comment">Id of the comment to return</param>
        /// <returns>A container with the comments, cursor and users concerned</returns>
        public static OsuCommentsContainer GetComment(this ApiClient client, uint comment)
        {
            var request = new OsuCommentRequest(comment);
            return client.Perform<OsuCommentsContainer>(request);
        }
    }
}
