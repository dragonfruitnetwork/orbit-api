// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;
using DragonFruit.Orbit.API.Objects.Comments;
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
        /// Get the latest comments posted on the osu! website for a specific commentable type
        /// </summary>
        /// <param name="client">The <see cref="ApiClient"/> to use</param>
        /// <returns>A container with the comments, cursor and users concerned</returns>
        public static OsuCommentsContainer GetComments(this ApiClient client, OsuCommentTarget target)
        {
            return client.GetComments(target, 1);
        }

        /// <summary>
        /// Get a specific page of comments posted on the osu! website for a specific commentable type
        /// </summary>
        /// <param name="client">The <see cref="ApiClient"/> to use</param>
        /// <returns>A container with the comments, cursor and users concerned</returns>
        public static OsuCommentsContainer GetComments(this ApiClient client, OsuCommentTarget target, int page)
        {
            var request = new OsuCommentsRequest
            {
                Page = page,
                Target = target
            };

            return client.Perform<OsuCommentsContainer>(request);
        }

        /// <summary>
        /// Get a specific page of comments posted on the osu! website for any commentable entity
        /// </summary>
        /// <param name="client">The <see cref="ApiClient"/> to use</param>
        /// <returns>A container with the comments, cursor and users concerned</returns>
        public static OsuCommentsContainer GetComments(this ApiClient client, int page)
        {
            var request = new OsuCommentsRequest
            {
                Page = page
            };

            return client.Perform<OsuCommentsContainer>(request);
        }

        /// <summary>
        /// Get a specific comment, and it's child comments
        /// </summary>
        /// <param name="client">The <see cref="ApiClient"/> to use</param>
        /// <param name="comment">Id of the comment to return</param>
        /// <returns>A container with the comments, cursor and users concerned</returns>
        public static OsuCommentsContainer GetComment(this ApiClient client, uint comment)
        {
            var request = new OsuCommentsRequest(comment);
            return client.Perform<OsuCommentsContainer>(request);
        }
    }
}
