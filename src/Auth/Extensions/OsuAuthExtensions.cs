// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Auth.Requests;

namespace DragonFruit.Orbit.Api.Auth.Extensions
{
    public static class OsuAuthExtensions
    {
        /// <summary>
        /// Revokes the current session and signals the client the token is invalid.
        /// This will throw if the request failed
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        public static void RevokeCurrentSession<T>(this T client) where T : OrbitClient
        {
            using (var response = client.Perform(new OsuSessionInvalidationRequest()))
            {
                response.EnsureSuccessStatusCode();
            }

            client.InvalidateToken();
        }

        /// <summary>
        /// Revokes the current session and signals the client the token is invalid.
        /// This will throw if the request failed
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        public static async Task RevokeCurrentSessionAsync<T>(this T client) where T : OrbitClient
        {
            using (var response = await client.PerformAsync(new OsuSessionInvalidationRequest()).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();
            }

            client.InvalidateToken();
        }
    }
}
