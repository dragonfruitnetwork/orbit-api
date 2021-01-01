// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Ecosystem.Enums
{
    public enum CommentSort
    {
        Old,

        [Description("Recent")]
        [ExternalValue("new")]
        Recent,

        [Description("Votes (newest)")]
        [ExternalValue("top")]
        Votes
    }
}
