// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuSessionRefreshRequest : OsuAuthRequest
    {
        public override string Grant => "refresh_token";

        public OsuSessionRefreshRequest(string token)
        {
            RefreshToken = token;
        }

        [FormParameter("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
