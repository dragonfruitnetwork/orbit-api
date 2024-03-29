﻿// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Auth.Requests;

namespace DragonFruit.Orbit.Api.Auth.Extensions
{
    public static class OsuClientAuthExtensions
    {
        /// <summary>
        /// Use the <see cref="OrbitClient"/> credentials to create a guest user access token
        /// </summary>
        /// <remarks>
        /// Client credentials don't issue refresh tokens
        /// </remarks>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        public static OsuAuthToken GetSessionToken(this OrbitClient client)
        {
            return client.Perform<OsuAuthToken>(new OsuClientAuthRequest());
        }

        /// <summary>
        /// Use the <see cref="OrbitClient"/> credentials to create a guest user access token
        /// </summary>
        /// <remarks>
        /// Client credentials don't issue refresh tokens
        /// </remarks>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        public static Task<OsuAuthToken> GetSessionTokenAsync(this OrbitClient client)
        {
            return client.PerformAsync<OsuAuthToken>(new OsuClientAuthRequest());
        }
    }
}
