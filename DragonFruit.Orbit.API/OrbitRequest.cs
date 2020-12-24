// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;

namespace DragonFruit.Orbit.Api
{
    public abstract class OrbitRequest : ApiRequest
    {
        public override string Path => $"{OrbitClient.BaseEndpoint}/api/v2/{Stub}";
        protected override bool RequireAuth => true;

        protected abstract string Stub { get; }

        // RequireAuth is protected/internal so the client can't see it (so we create a redirect)
        internal bool ValidateToken => RequireAuth;
    }
}
