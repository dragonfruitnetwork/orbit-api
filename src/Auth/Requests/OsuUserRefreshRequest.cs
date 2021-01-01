// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.Api.Auth.Requests
{
    public class OsuUserRefreshRequest : OsuAuthRequest
    {
        public override string GrantType => "refresh_token";

        public OsuUserRefreshRequest(string refreshToken)
        {
            RefreshToken = refreshToken;
        }

        [FormParameter("refresh_token")]
        public string RefreshToken { get; }
    }
}
