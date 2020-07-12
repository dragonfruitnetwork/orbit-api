// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.ComponentModel;

namespace DragonFruit.Orbit.API.Objects.Enums
{
    public enum GameMode
    {
        [Description("osu!standard")]
        Osu = 0,

        [Description("osu!taiko")]
        Taiko = 1,

        [Description("osu!catch")]
        Fruits = 2,

        [Description("osu!mania")]
        Mania = 3
    }

    internal static class GameModeExtensions
    {
        internal static string ToQueryableValue(this GameMode? mode)
        {
            return mode == null ? string.Empty : mode.ToString().ToLowerInvariant();
        }

        internal static GameMode? AsGameMode(this string input)
        {
            if (Enum.TryParse(typeof(GameMode), input, true, out var mode))
            {
                return (GameMode)mode;
            }

            return null;
        }
    }
}
