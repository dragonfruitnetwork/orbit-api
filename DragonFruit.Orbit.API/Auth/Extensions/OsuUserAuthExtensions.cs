// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.Auth.Requests;

namespace DragonFruit.Orbit.Api.Auth.Extensions
{
    public static class OsuUserAuthExtensions
    {
        /// <summary>
        /// Exchanges a user authorization code for a session-refresh token pair
        /// </summary>
        public static OsuAuthToken CreateSession<T>(this T client, string code, string redirectUri) where T : OrbitClient
        {
            var request = new OsuUserAuthRequest(code, redirectUri);
            return client.Perform(request);
        }

        /// <summary>
        /// Exchanges a refresh code for a new session-refresh token pair
        /// </summary>
        public static OsuAuthToken RefreshSession<T>(this T client, string refreshCode) where T : OrbitClient
        {
            var request = new OsuUserRefreshRequest(refreshCode);
            return client.Perform(request);
        }

        /// <summary>
        /// Exchanges a refresh code for a new session-refresh token pair
        /// </summary>
        public static OsuAuthToken RefreshSession<T>(this T client, OsuAuthToken currentToken) where T : OrbitClient
        {
            if (string.IsNullOrEmpty(currentToken.RefreshToken))
            {
                throw new ArgumentNullException(nameof(currentToken.RefreshToken));
            }

            return RefreshSession(client, currentToken.RefreshToken);
        }
    }
}
