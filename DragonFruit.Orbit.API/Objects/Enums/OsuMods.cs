// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.API.Objects.Enums
{
    //from https://github.com/ppy/osu-api/wiki#mods
    public enum OsuMods
    {
        None = 0x0,
        NoFail = 0x1,
        Easy = 0x2,
        TouchDevice = 0x4,
        Hidden = 0x8,
        HardRock = 0x10,
        SuddenDeath = 0x20,
        DoubleTime = 0x40,
        Relax = 0x80,
        HalfTime = 0x100,
        Nightcore = 0x200,
        Flashlight = 0x400,
        Autoplay = 0x800,
        SpunOut = 0x1000,
        Relax2 = 0x2000, // Autopilot
        Perfect = 0x4000,
        Key4 = 0x8000,
        Key5 = 0x10000,
        Key6 = 0x20000,
        Key7 = 0x40000,
        Key8 = 0x80000,
        FadeIn = 0x100000,
        Random = 0x200000,
        Cinema = 0x400000,
        Target = 0x800000,
        Key9 = 0x1000000,
        KeyCoop = 0x2000000,
        Key1 = 0x4000000,
        Key3 = 0x8000000,
        Key2 = 0x10000000,
        ScoreV2 = 0x20000000,
        Mirror = 0x40000000,
        KeyMod = Key1 | Key2 | Key3 | Key4 | Key5 | Key6 | Key7 | Key8 | Key9 | KeyCoop,
        FreeModAllowed = NoFail | Easy | Hidden | HardRock | SuddenDeath | Flashlight | FadeIn | Relax | Relax2 | SpunOut | KeyMod,
        ScoreIncreaseMods = Hidden | HardRock | DoubleTime | Flashlight | FadeIn
    }
}
