// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Beatmaps.Enums
{
    public enum BeatmapsetCategory
    {
        Any,

        [Description("Has Leaderboard")]
        [ExternalValue("leaderboard")]
        HasLeaderboard,

        Ranked,
        Qualified,
        Loved,

        [ExternalValue("favourites")]
        Favourite,

        [Description("Pending & WIP")]
        Pending,

        Graveyard,

        [Description("My Maps")]
        [ExternalValue("mine")]
        Owned,
    }
}
