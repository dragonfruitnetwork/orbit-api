// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Ecosystem.Enums
{
    public enum ChangelogTarget
    {
        [Description("Stable")]
        [ExternalValue("stable40")]
        Stable,

        [Description("Stable Fallback")]
        [ExternalValue("stable")]
        StableFallback,

        [Description("Beta")]
        [ExternalValue("beta40")]
        Beta,

        [Description("Cutting Edge")]
        CuttingEdge,

        [Description("Lazer")]
        Lazer,

        [Description("Web")]
        Web,
    }
}
