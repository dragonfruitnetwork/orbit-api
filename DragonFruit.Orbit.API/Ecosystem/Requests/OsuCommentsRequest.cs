// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Interfaces;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Ecosystem.Requests
{
    public class OsuCommentsRequest : OrbitRequest, IPaginatedRequest
    {
        protected override string Stub => CommentId.HasValue ? $"comments/{CommentId.Value}" : "comments";

        protected override IEnumerable<KeyValuePair<string, string>> AdditionalQueries => CursorUtils.ToQueries(Cursor);

        /// <summary>
        /// Get the latest comments
        /// </summary>
        public OsuCommentsRequest()
        {
        }

        /// <summary>
        /// Get comments for the specified entity
        /// </summary>
        public OsuCommentsRequest(CommentableType? type, uint? typeId)
        {
            Type = type;
            TypeId = typeId;
        }

        /// <summary>
        /// Get the replies to a comment (by providing the parent id)
        /// </summary>
        public OsuCommentsRequest(uint parentId, bool parent)
        {
            ParentId = parentId;
        }

        public uint? CommentId { get; set; }

        /// <summary>
        /// Sort method for the comments
        /// </summary>
        public CommentSort? Sort { get; set; }

        /// <summary>
        /// The type of entity the comment was posted on
        /// </summary>
        public CommentableType? Type { get; set; }

        /// <summary>
        /// The id of the entity the comment was posted on
        /// </summary>
        [QueryParameter("commentable_id")]
        public uint? TypeId { get; set; }

        /// <summary>
        /// Id of the comment to get replies to
        /// </summary>
        [QueryParameter("parent_id")]
        public uint? ParentId { get; set; }

        [QueryParameter("page")]
        public uint? Page { get; set; }

        [QueryParameter("limit")]
        public uint? Limit { get; set; }

        [QueryParameter("sort")]
        protected string CommentSortMode => Sort?.ToExternalValue();

        [QueryParameter("commentable_type")]
        protected string CommentTargetType => Type?.ToExternalValue();

        public IReadOnlyDictionary<string, string> Cursor { get; set; }
    }
}
