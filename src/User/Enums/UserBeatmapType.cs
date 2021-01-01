// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.User.Enums
{
    public enum UserBeatmapType
    {
        Favourite,
        Loved,
        Unranked,

        [ExternalValue("graveyard")]
        Graveyarded,

        [Description("Most Played")]
        [ExternalValue("most_played")]
        MostPlayed,

        [Description("Ranked and Approved")]
        [ExternalValue("ranked_and_approved")]
        RankedAndApproved,
    }
}
