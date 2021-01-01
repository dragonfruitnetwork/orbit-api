// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;

namespace DragonFruit.Orbit.Api.Legacy.Enums
{
    public enum LegacyRank
    {
        [Description("SS+")]
        XH,

        [Description("S+")]
        SH,

        [Description("SS")]
        X,
        S,
        A,
        B,
        C,
        D,
        F,

        [Description("Unknown")]
        N
    }
}
