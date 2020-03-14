// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.API.OAuth
{
    public class OAuthCodeRequest : OAuthRequest
    {
        public OAuthCodeRequest()
        {
        }

        public OAuthCodeRequest(string code)
        {
            AuthCode = code;
        }

        public override string Grant => "authorization_code";

        [FormParameter("code")]
        public string AuthCode { get; set; }

        [FormParameter("redirect_uri")]
        public string RedirectUrl { get; set; }
    }
}
