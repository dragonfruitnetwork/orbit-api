// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Objects.Enums;

namespace DragonFruit.Orbit.API.Legacy
{
    public abstract class LegacyRequest : LegacyRequestBase
    {
        [QueryParameter("u")]
        public string User { get; set; }

        public GameMode? GameMode { get; set; }

        [QueryParameter("type")]
        private string Type => IsUsername ?? true ? "string" : "id";

        [QueryParameter("m")]
        private string ModeQuery => GameMode != null ? ((int)GameMode).ToString() : null;

        public bool? IsUsername { get; set; }
    }
}
