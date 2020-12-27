// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Leaderboards.Enums
{
    public enum LeaderboardVariant
    {
        [Description("osu!mania 4k")]
        [ExternalValue("4k")]
        Mania4K,

        [Description("osu!mania 7k")]
        [ExternalValue("7k")]
        Mania7K
    }
}
