// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;

namespace DragonFruit.Orbit.Api.Legacy.Enums
{
    public enum LegacyRank
    {
        [Description("SS+")]
        SSH,

        [Description("S+")]
        SH,

        SS,
        S,
        A,
        B,
        C,
        D,
        F,

        [Description("Unknown")]
        N = F
    }
}
