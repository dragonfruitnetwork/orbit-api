// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Ecosystem.Entities;
using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Ecosystem.Requests;

namespace DragonFruit.Orbit.Api.Ecosystem.Extensions
{
    public static class OsuCommentsExtensions
    {
        public static OsuCommentsSummary GetComments<T>(this T client, OsuCommentsSummary last = null, uint? limit = null) where T : OrbitClient
        {
            var request = new OsuCommentsRequest
            {
                Limit = limit,
                Cursor = last?.Cursor
            };

            return client.Perform<OsuCommentsSummary>(request);
        }

        public static OsuCommentsSummary GetComments<T>(this T client, uint commentId, OsuCommentsSummary last = null, uint? limit = null) where T : OrbitClient
        {
            var request = new OsuCommentsRequest(commentId, true)
            {
                Limit = limit,
                Cursor = last?.Cursor
            };

            return client.Perform<OsuCommentsSummary>(request);
        }

        public static OsuCommentsSummary GetComments<T>(this T client, CommentableType type, uint typeId, OsuCommentsSummary last = null, uint? limit = null) where T : OrbitClient
        {
            var request = new OsuCommentsRequest(type, typeId)
            {
                Limit = limit,
                Cursor = last?.Cursor
            };

            return client.Perform<OsuCommentsSummary>(request);
        }

        public static OsuCommentsSummary GetComment<T>(this T client, uint commentId, OsuCommentsSummary last = null, uint? limit = null) where T : OrbitClient
        {
            var request = new OsuCommentsRequest(commentId, false)
            {
                Limit = limit,
                Cursor = last?.Cursor
            };

            return client.Perform<OsuCommentsSummary>(request);
        }
    }
}
