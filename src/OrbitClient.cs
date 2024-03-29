﻿// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DragonFruit.Data;
using DragonFruit.Data.Serializers.Newtonsoft;
using DragonFruit.Orbit.Api.Auth;
using Nito.AsyncEx;

namespace DragonFruit.Orbit.Api
{
    public abstract class OrbitClient : ApiClient<ApiJsonSerializer>
    {
        private OsuAuthToken _token;
        private readonly AsyncLock _tokenLock = new();

        /// <summary>
        /// Base endpoint all <see cref="OrbitRequest"/>s are sent to.
        /// This property is static and is used regardless of the client instance
        /// </summary>
        /// <remarks>
        /// Can be changed to use another server but is not recommended
        /// </remarks>
        public static string BaseEndpoint { get; set; } = "https://osu.ppy.sh";

        /// <summary>
        /// Optional flag to allow <see cref="HttpStatusCode.NotFound"/> to return null instead of an exception
        /// </summary>
        protected virtual bool ThrowNotFound => false;

        /// <summary>
        /// Client id from the osu! site, for use when requesting tokens for api access
        /// </summary>
        protected internal virtual string ClientId => null;

        /// <summary>
        /// Client secret associated with the <see cref="ClientId"/>
        /// </summary>
        /// <remarks>
        /// You should read this in from a file, env var, etc. (just don't hard-code it)
        /// </remarks>
        protected internal virtual string ClientSecret => null;

        /// <summary>
        /// Method for getting a valid <see cref="OsuAuthToken"/> when the previous one has expired or does not exist.
        /// </summary>
        protected abstract OsuAuthToken GetToken();

        /// <summary>
        /// Injects the current bearer token into the <see cref="OrbitRequest"/> provided, allowing for a refresh to occur if expired
        /// </summary>
        protected internal OsuAuthToken RequestAccessToken()
        {
            // use the cached token if not-null and non-expired
            // because this is nullable, we want Expired to be false
            if (_token?.Expired is false)
            {
                return _token;
            }

            // block multiple requests
            using (_tokenLock.Lock())
            {
                // any requests made while the first check failed will miss this
                if (_token == null || _token.Expired)
                {
                    _token = GetToken();
                }

                return _token;
            }
        }

        protected override Task<T> ValidateAndProcess<T>(HttpResponseMessage response)
        {
            switch (response.StatusCode)
            {
                // todo add token exp exception

                case HttpStatusCode.NoContent:
                case HttpStatusCode.NotFound when !ThrowNotFound:
                    return default;

                default:
                    return base.ValidateAndProcess<T>(response);
            }
        }

        /// <summary>
        /// Signals to the client the token should be reset
        /// </summary>
        protected internal void InvalidateToken() => _token = null;
    }
}
