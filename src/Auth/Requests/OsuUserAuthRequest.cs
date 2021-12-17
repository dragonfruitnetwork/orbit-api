// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Data.Parameters;

namespace DragonFruit.Orbit.Api.Auth.Requests
{
    public class OsuUserAuthRequest : OsuAuthRequest
    {
        public override string GrantType => "authorization_code";

        public OsuUserAuthRequest(string authCode, string redirectUrl)
        {
            AuthCode = authCode;
            RedirectUrl = redirectUrl;
        }

        [FormParameter("code")]
        public string AuthCode { get; set; }

        [FormParameter("redirect_uri")]
        public string RedirectUrl { get; set; }
    }
}
