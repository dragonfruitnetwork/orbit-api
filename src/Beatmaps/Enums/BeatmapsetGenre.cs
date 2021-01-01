// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;

namespace DragonFruit.Orbit.Api.Beatmaps.Enums
{
    public enum BeatmapsetGenre
    {
        Any = 0,
        Unspecified = 1,

        [Description("Video Game")]
        VideoGame = 2,
        Anime = 3,
        Rock = 4,
        Pop = 5,
        Other = 6,
        Novelty = 7,

        [Description("Hip Hop")]
        HipHop = 9,
        Electronic = 10,
        Metal = 11,
        Classical = 12,
        Folk = 13,
        Jazz = 14
    }
}
