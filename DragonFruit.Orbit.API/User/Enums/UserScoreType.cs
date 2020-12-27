// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.User.Enums
{
    public enum UserScoreType
    {
        [ExternalValue("bests")]
        Best,

        [ExternalValue("firsts")]
        FirstPlace,

        [ExternalValue("recent")]
        Recent
    }
}
