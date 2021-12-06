// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Security.Authentication;
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

        protected override void OnRequestExecuting(ApiClient client)
        {
            if (client is OrbitClient orbit)
            {
                // inject api key if we have a client
                ApiKey = orbit.LegacyKey ?? throw new AuthenticationException($"{nameof(orbit.LegacyKey)} has no value");
            }
        }
    }
}
