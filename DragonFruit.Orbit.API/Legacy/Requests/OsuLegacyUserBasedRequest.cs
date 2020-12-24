// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Legacy.Enums;

namespace DragonFruit.Orbit.Api.Legacy.Requests
{
    public abstract class OsuLegacyUserBasedRequest : OrbitLegacyRequest
    {
        [QueryParameter("u")]
        public string UserIdentifier { get; set; }

        [QueryParameter("type")]
        public bool? IsIdentifierUsername { get; set; }

        [QueryParameter("m")]
        public LegacyMode? Mode { get; set; }
    }
}
