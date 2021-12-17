// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Auth.Requests;

namespace DragonFruit.Orbit.Api.Auth.Extensions
{
    public static class OsuUserAuthExtensions
    {
        /// <summary>
        /// Exchanges a user authorization code for a session-refresh token pair
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="code">The code from the user's redirect</param>
        /// <param name="redirectUri">The url the client was redirected to</param>
        public static Task<OsuAuthToken> GetSessionTokenAsync<T>(this T client, string code, string redirectUri) where T : OrbitClient
        {
            return client.PerformAsync<OsuAuthToken>(new OsuUserAuthRequest(code, redirectUri));
        }

        /// <summary>
        /// Exchanges a refresh code for a new session-refresh token pair
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="refreshCode">The code to exchange for the new pair</param>
        public static Task<OsuAuthToken> RefreshSessionAsync<T>(this T client, string refreshCode) where T : OrbitClient
        {
            return client.PerformAsync<OsuAuthToken>(new OsuUserRefreshRequest(refreshCode));
        }

        /// <summary>
        /// Exchanges a refresh code for a new session-refresh token pair
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="currentToken">The current token being used</param>
        public static Task<OsuAuthToken> RefreshSessionAsync<T>(this T client, OsuAuthToken currentToken) where T : OrbitClient
        {
            return RefreshSessionAsync(client, currentToken.RefreshToken);
        }
    }
}
