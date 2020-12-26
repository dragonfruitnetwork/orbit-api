// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Ecosystem.Enums
{
    public enum CommentableType
    {
        [Description("News Post")]
        [ExternalValue("news_post")]
        NewsPost,

        [Description("Changelog Release")]
        [ExternalValue("build")]
        ChangelogRelease,

        [Description("Beatmapset")]
        Beatmapset
    }
}
