// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Ecosystem.Enums
{
    public enum SearchTarget
    {
        All,
        User,

        [ExternalValue("wiki_page")]
        WikiPage
    }
}
