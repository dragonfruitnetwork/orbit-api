// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Objects.Enums;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuCommentsRequest : OrbitPaginatedRequest
    {
        private OsuCommentTarget _target;

        protected override string Route => "/comments/";
        protected override bool RequireAuth => false;
        protected override bool UsesOffset => false;

        /// <summary>
        /// Get the latest comments from anything that can be commented on
        /// </summary>
        public OsuCommentsRequest()
        {
        }

        /// <summary>
        /// Get the comments associated with a specific commentable entity.
        /// </summary>
        public OsuCommentsRequest(uint commentableId, OsuCommentTarget targetType)
        {
            CommentableId = commentableId;
            Type = targetType;
        }

        /// <summary>
        /// Get a specific page of comments associated with a specific commentable entity.
        /// </summary>
        public OsuCommentsRequest(uint commentableId, OsuCommentTarget targetType, uint page)
            : this(commentableId, targetType)
        {
            Page = page;
        }

        /// <summary>
        /// The id of the item being commented on. (a update release, news article, etc.)
        /// </summary>
        [QueryParameter("commentable_id")]
        public uint? CommentableId { get; set; }

        /// <summary>
        /// The maximum number of items to return in a single page
        /// </summary>
        [QueryParameter("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// If specified, will return child comments for this comment
        /// </summary>
        [QueryParameter("parent_id")]
        public uint? ParentId { get; set; }

        /// <summary>
        /// The <see cref="OsuCommentsSortCriteria"/> for sorting the return values by
        /// </summary>
        public OsuCommentsSortCriteria? Sort { get; set; }

        /// <summary>
        /// The type of item the <see cref="CommentableId"/> is
        /// </summary>
        public OsuCommentTarget Type
        {
            get => _target;
            set
            {
                _target = value;
                TypeString = value switch
                {
                    OsuCommentTarget.NewsPost => "news_post",
                    _ => value.ToString().ToLowerInvariant()
                };
            }
        }

        [QueryParameter("commentable_type")]
        private string? TypeString { get; set; }

        [QueryParameter("sort")]
        private string? SortString => Sort.HasValue ? Sort.ToString().ToLowerInvariant() : null;
    }
}
