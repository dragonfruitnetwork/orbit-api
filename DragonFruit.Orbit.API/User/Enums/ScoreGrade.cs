// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;

namespace DragonFruit.Orbit.Api.User.Enums
{
    public enum ScoreGrade
    {
        N,
        F,
        D,
        C,
        B,
        A,
        S,

        [Description(@"S+")]
        SH,

        [Description(@"SS")]
        X,

        [Description(@"SS+")]
        XH,
    }
}
