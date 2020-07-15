// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuCommentRequest : OrbitApiRequest
    {
        protected override string Route => $"/comments/{CommentId}";

        /// <summary>
        /// Create a request to get a comment and its replies (for up to two levels)
        /// </summary>
        public OsuCommentRequest(uint commentId)
        {
            CommentId = commentId;
        }

        public uint CommentId { get; set; }
    }
}
