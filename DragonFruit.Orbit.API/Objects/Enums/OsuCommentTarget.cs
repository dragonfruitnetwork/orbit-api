// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;

namespace DragonFruit.Orbit.API.Objects.Enums
{
    public enum OsuCommentTarget
    {
        Beatmapset,
        NewsPost,
        Build
    }

    internal static class OsuCommentTargetExtensions
    {
        public static string ToQueryable(this OsuCommentTarget target)
        {
            return target switch
            {
                OsuCommentTarget.NewsPost => "news_post",
                _ => target.ToString().ToLowerInvariant()
            };
        }

        public static OsuCommentTarget FromQueryable(string input)
        {
            return input switch
            {
                "news_post" => OsuCommentTarget.NewsPost,
                _ => (OsuCommentTarget)Enum.Parse(typeof(OsuCommentTarget), input, true)
            };
        }
    }
}
