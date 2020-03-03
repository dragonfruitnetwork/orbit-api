// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.API.Attributes;

namespace DragonFruit.Orbit.API.Auth
{
    public class OAuthRefreshRequest : OAuthRequest
    {
        public override string GrantType => "refresh_token";

        [FormParameter("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
