// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.API.Requests
{
    public abstract class OsuAuthRequest : ApiRequest
    {
        public override string Path => "https://osu.ppy.sh/oauth/token";
        protected override Methods Method => Methods.Post;
        protected override DataTypes DataType => DataTypes.Encoded;

        [FormParameter("grant_type")]
        public virtual string Grant { get; }

        [FormParameter("client_id")]
        public string ClientId { get; set; }

        [FormParameter("client_secret")]
        public string ClientSecret { get; set; }
    }
}
