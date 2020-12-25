// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.ComponentModel;

namespace DragonFruit.Orbit.Api.Ecosystem.Enum
{
    public enum ChangelogTarget
    {
        [Description("Stable")]
        Stable40,

        [Description("Stable Fallback")]
        Stable,

        [Description("Beta")]
        Beta40,

        [Description("Cutting Edge")]
        CuttingEdge,

        [Description("Lazer")]
        Lazer,

        [Description("Web")]
        Web,
    }
}
