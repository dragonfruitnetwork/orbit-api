// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Data.Parameters;

namespace DragonFruit.Orbit.Api.Auth.Requests
{
    /// <summary>
    /// A request to fetch client credentials for public, guest-like access to the osu! api
    /// </summary>
    public class OsuClientAuthRequest : OsuAuthRequest
    {
        public override string GrantType => "client_credentials";

        [FormParameter("scope")]
        public string Scopes => "public";
    }
}
