// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api
{
    public enum GameMode
    {
        [Description("osu!")]
        [ExternalValue("osu")]
        Standard,

        [Description("osu!taiko")]
        Taiko,

        [Description("osu!catch")]
        [ExternalValue("fruits")]
        Catch,

        [Description("osu!mania")]
        Mania
    }
}
