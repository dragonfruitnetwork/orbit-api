// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Data.Parameters;

namespace DragonFruit.Orbit.Api.Auth.Requests
{
    public class OsuUserRefreshRequest : OsuAuthRequest
    {
        public override string GrantType => "refresh_token";

        public OsuUserRefreshRequest(string refreshToken)
        {
            // todo replace with allownull check
            if (string.IsNullOrEmpty(refreshToken))
            {
                throw new ArgumentNullException(nameof(refreshToken));
            }

            RefreshToken = refreshToken;
        }

        [FormParameter("refresh_token")]
        public string RefreshToken { get; }
    }
}
