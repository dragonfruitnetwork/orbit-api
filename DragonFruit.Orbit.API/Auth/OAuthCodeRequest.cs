// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.API.Attributes;

namespace DragonFruit.Orbit.API.Auth
{
    public class OAuthCodeRequest : OAuthRequest
    {
        public override string GrantType => "authorization_code";

        [FormParameter("code")]
        public string AuthCode { get; set; }
    }
}
