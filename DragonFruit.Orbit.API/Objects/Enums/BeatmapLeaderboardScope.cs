// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;

namespace DragonFruit.Orbit.API.Objects.Enums
{
    public enum BeatmapLeaderboardScope
    {
        [Description("Country Ranking")]
        Country,

        [Description("Global Ranking")]
        Global,

        [Description("Friend Ranking")]
        Friend,
    }
}
