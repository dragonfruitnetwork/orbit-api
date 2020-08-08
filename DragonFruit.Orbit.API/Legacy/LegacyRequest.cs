// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Objects.Enums;

namespace DragonFruit.Orbit.API.Legacy
{
    public abstract class LegacyRequest : ApiRequest
    {
        [QueryParameter("k")]
        internal string ApiKey { get; set; }

        [QueryParameter("u")]
        public string User { get; set; }

        [QueryParameter("limit")]
        public uint? Limit { get; set; }

        public GameMode? GameMode { get; set; }

        public bool? IsUsername { get; set; }

        [QueryParameter("type")]
        private string Type => IsUsername ?? true ? "string" : "id";

        [QueryParameter("m")]
        private string ModeQuery => GameMode != null ? ((int)GameMode).ToString() : null;
    }

    /// <summary>
    /// A request who's result is in an enumerable form (<see cref="IEnumerable{T}"/>
    /// </summary>
    public abstract class LegacyEnumerableResponseRequest : LegacyRequest
    {
    }
}
