// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Objects.Comments;
using DragonFruit.Orbit.API.Objects.Enums;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuCommentsRequest : OrbitApiRequest
    {
        private OsuCommentTarget _target;

        protected override string Route => $"/comments/{CommentId.ToString() ?? string.Empty}";
        public override bool RequireAuth => false;

        public OsuCommentsRequest()
        {
        }

        public OsuCommentsRequest(uint commentId)
        {
            CommentId = commentId;
        }

        [QueryParameter("page")]
        public int? Page { get; set; }

        [QueryParameter("commentable_id")]
        public uint? CommentableId { get; set; }

        [QueryParameter("commentable_type")]
        private string TypeString { get; set; }

        [QueryParameter("sort")]
        private string SortString => Sort.HasValue ? Sort.ToString().ToLowerInvariant() : null;

        public uint? CommentId { get; set; }

        public OsuCommentsSortCriteria? Sort { get; set; }

        public OsuCommentTarget Target
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
    }
}
