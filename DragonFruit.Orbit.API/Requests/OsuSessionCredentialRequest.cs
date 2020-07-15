// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuSessionCredentialRequest : OsuAuthRequest
    {
        public override string Grant => "client_credentials";

        [FormParameter("scope")]
        private string ScopeString => "public";
    }
}
