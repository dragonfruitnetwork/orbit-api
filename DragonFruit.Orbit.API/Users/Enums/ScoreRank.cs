// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;

namespace DragonFruit.Orbit.API.Scoring.Enums
{
    public enum ScoreRank
    {
        [Description("None")]
        N,

        [Description("F")]
        F,

        [Description("D")]
        D,

        [Description("C")]
        C,

        [Description("B")]
        B,

        [Description("A")]
        A,

        [Description("S")]
        S,

        [Description("S+")]
        SH,

        [Description("SS")]
        X,

        [Description("SS+")]
        XH,
    }
}
