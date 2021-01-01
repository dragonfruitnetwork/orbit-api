// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.Api.Legacy.Requests
{
    public abstract class OsuLegacyUserBasedRequest : OsuLegacyRequest
    {
        protected OsuLegacyUserBasedRequest(string userIdentifier)
        {
            UserIdentifier = userIdentifier;
        }

        [QueryParameter("u")]
        public string UserIdentifier { get; set; }

        [QueryParameter("type")]
        public bool? IsIdentifierUsername { get; set; }

        [QueryParameter("m", EnumHandlingMode.Numeric)]
        public GameMode? Mode { get; set; }
    }
}
