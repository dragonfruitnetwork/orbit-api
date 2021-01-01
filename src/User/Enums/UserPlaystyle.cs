// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;

namespace DragonFruit.Orbit.Api.User.Enums
{
    [Flags]
    public enum UserPlaystyle
    {
        // numeric values mean nothing - codacy was moaning about it... (SonarCSharp_S2345)
        Mouse = 1,
        Touch = 2,
        Keyboard = 4,
        Tablet = 8
    }
}
