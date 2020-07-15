// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuSessionGrantRequest : OsuAuthRequest
    {
        public override string Grant => "authorization_code";

        /// <summary>
        /// Convert a user's auth code into a usable access token
        /// </summary>
        public OsuSessionGrantRequest(string code, string redirectUrl)
        {
            AuthCode = code;
            RedirectUrl = redirectUrl;
        }

        [FormParameter("code")]
        public string AuthCode { get; set; }

        [FormParameter("redirect_uri")]
        public string RedirectUrl { get; set; }
    }
}
