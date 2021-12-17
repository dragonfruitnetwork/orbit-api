﻿// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Ecosystem.Entities;
using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Ecosystem.Requests;

namespace DragonFruit.Orbit.Api.Ecosystem.Extensions
{
    public static class OsuCommentsExtensions
    {
        /// <summary>
        /// Get latest comments posted on anything that can be commented on
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="last">Optional response of the last request for getting the "next page" of results</param>
        /// <param name="limit">Optional upper-limit for returned responses</param>
        /// <returns>
        /// Comments summary, including all metadata (users/maps/posts) the comments relate to.
        /// Returns null if there are no more comments (based on the cursor)
        /// </returns>
        public static Task<OsuCommentsSummary> GetCommentsAsync<T>(this T client, OsuCommentsSummary last = null, uint? limit = null) where T : OrbitClient
        {
            var request = GetRequest(last, limit, () => new OsuCommentsRequest());
            return request is null ? null : client.PerformAsync<OsuCommentsSummary>(request);
        }

        /// <summary>
        /// Gets child comments posted in reply to a comment (upto 2 levels deep)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="commentId">The id of the comment to get children for</param>
        /// <param name="last">Optional response of the last request for getting the "next page" of results</param>
        /// <param name="limit">Optional upper-limit for returned responses</param>
        /// <returns>
        /// Comments summary, including all metadata (users/maps/posts) the comments relate to.
        /// Returns null if there are no more comments (based on the cursor)
        /// </returns>
        public static Task<OsuCommentsSummary> GetCommentsAsync<T>(this T client, uint commentId, OsuCommentsSummary last = null, uint? limit = null) where T : OrbitClient
        {
            var request = GetRequest(last, limit, () => new OsuCommentsRequest(commentId, true));
            return request is null ? null : client.PerformAsync<OsuCommentsSummary>(request);
        }

        /// <summary>
        /// Gets child comments posted in reply to a comment (upto 2 levels deep)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="type">The <see cref="CommentableType"/> the <see cref="typeId"/> is</param>
        /// <param name="typeId">The id of the entity to get comments for</param>
        /// <param name="last">Optional response of the last request for getting the "next page" of results</param>
        /// <param name="limit">Optional upper-limit for returned responses</param>
        /// <returns>
        /// Comments summary, including all metadata (users/maps/posts) the comments relate to.
        /// Returns null if there are no more comments (based on the cursor)
        /// </returns>
        public static Task<OsuCommentsSummary> GetCommentsAsync<T>(this T client, CommentableType type, uint typeId, OsuCommentsSummary last = null, uint? limit = null) where T : OrbitClient
        {
            var request = GetRequest(last, limit, () => new OsuCommentsRequest(type, typeId));
            return request is null ? null : client.PerformAsync<OsuCommentsSummary>(request);
        }

        /// <summary>
        /// Get a single comment (and its neighbouring comments?)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="commentId">Id of the comment to fetch</param>
        /// <param name="last">Optional response of the last request for getting the "next page" of results</param>
        /// <param name="limit">Optional upper-limit for returned responses</param>
        /// <returns>
        /// Comments summary, including all metadata (users/maps/posts) the comment(s) relate to.
        /// Returns null if there are no more comments (based on the cursor)
        /// </returns>
        public static Task<OsuCommentsSummary> GetCommentAsync<T>(this T client, uint commentId, OsuCommentsSummary last = null, uint? limit = null) where T : OrbitClient
        {
            var request = GetRequest(last, limit, () => new OsuCommentsRequest(commentId, false));
            return request is null ? null : client.PerformAsync<OsuCommentsSummary>(request);
        }

        private static OsuCommentsRequest GetRequest(OsuCommentsSummary last, uint? limit, Func<OsuCommentsRequest> factory)
        {
            if (last?.More == false)
            {
                return null;
            }

            var request = factory.Invoke();
            request.Limit = limit;
            request.Cursor = last?.Cursor;

            return request;
        }
    }
}
