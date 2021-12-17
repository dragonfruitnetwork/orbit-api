// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Extensions;

namespace DragonFruit.Orbit.Api
{
    public abstract class OrbitRequest : ApiRequest
    {
        public override string Path => $"{OrbitClient.BaseEndpoint}/api/v2/{Stub}";
        protected override bool RequireAuth => true;

        protected abstract string Stub { get; }

        // RequireAuth is protected/internal so the client can't see it (so we create a redirect)
        internal bool IncludeToken => RequireAuth;

        protected override void OnRequestExecuting(ApiClient client)
        {
            if (client is OrbitClient orbit)
            {
                // inject bearer token if we have access otherwise this will fail at the validate stage
                this.WithAuthHeader($"Bearer {orbit.RequestAccessToken().AccessToken}");
            }
        }
    }
}
