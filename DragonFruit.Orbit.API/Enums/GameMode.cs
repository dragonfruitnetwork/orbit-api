// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;

namespace DragonFruit.Orbit.API.Enums
{
    public enum GameMode
    {
        Default = 0,

        [Description("osu!standard")]
        Osu = 1,

        [Description("osu!taiko")]
        Taiko = 2,

        [Description("osu!catch")]
        Fruits = 3,

        [Description("osu!mania")]
        Mania = 4
    }
}
