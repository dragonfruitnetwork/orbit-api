// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.Api.Legacy.Requests
{
    public abstract class OsuLegacyRequest : ApiRequest
    {
        public override string Path => $"{OrbitClient.BaseEndpoint}/api/get_{Target}";

        public abstract string Target { get; }

        [QueryParameter("k")]
        public string ApiKey { get; set; }
    }
}
