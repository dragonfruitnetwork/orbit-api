// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.API;
using DragonFruit.Common.API.Attributes;

namespace DragonFruit.Orbit.API.Auth
{
    [ApiPath("https://osu.ppy.sh/oauth/token", Methods.PostForm, acceptedContent: "application/x-www-form-urlencoded")]
    public abstract class OAuthRequest : ApiRequest
    {
        [FormParameter("grant_type")]
        public virtual string GrantType { get; }

        [FormParameter("client_id")]
        public string ClientId { get; set; }

        [FormParameter("client_secret")]
        public string ClientSecret { get; set; }

        [FormParameter("redirect_uri")]
        public string RedirectUrl { get; set; }
    }
}
