// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.API.OAuth
{
    public abstract class OAuthRequest : ApiRequest
    {
        public override string Path => "https://osu.ppy.sh/oauth/token";

        public override string AcceptedContent => "application/x-www-form-urlencoded";

        public override Methods Method => Methods.PostForm;

        [FormParameter("grant_type")]
        public virtual string Grant { get; }

        [FormParameter("client_id")]
        public string ClientId { get; set; }

        [FormParameter("client_secret")]
        public string ClientSecret { get; set; }
    }
}
