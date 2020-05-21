// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Enums;

namespace DragonFruit.Orbit.API.Legacy
{
    public abstract class LegacyRequest : LegacyRequestBase
    {
        [QueryParameter("u")]
        public string User { get; set; }

        [QueryParameter("m")]
        public GameMode? GameMode { get; set; }

        [QueryParameter("type")]
        public string Type => IsUsername ?? true ? "string" : "id";

        public bool? IsUsername { get; set; }
    }
}
