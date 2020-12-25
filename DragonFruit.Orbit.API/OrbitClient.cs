// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Threading;
using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Extensions;
using DragonFruit.Common.Data.Handlers;
using DragonFruit.Orbit.Api.Auth;
using DragonFruit.Orbit.Api.Auth.Requests;
using DragonFruit.Orbit.Api.Legacy.Requests;

namespace DragonFruit.Orbit.Api
{
    public abstract class OrbitClient : ApiClient
    {
        internal const string BaseEndpoint = "https://osu.ppy.sh";

        private OsuAuthToken _token;

        /// <summary>
        /// Legacy api key to use with v1 requests
        /// </summary>
        protected virtual string LegacyKey => null;

        /// <summary>
        /// Client id from the osu! site, for use when requesting tokens for api access
        /// </summary>
        protected virtual string ClientId => null;

        /// <summary>
        /// Client secret associated with the <see cref="ClientId"/>
        /// </summary>
        /// <remarks>
        /// You should read this in from a file, env var, etc. (just don't hard-code it)
        /// </remarks>
        protected virtual string ClientSecret => null;

        /// <summary>
        /// Method for getting a valid <see cref="OsuAuthToken"/> when the previous one has expired or does not exist.
        /// </summary>
        protected abstract OsuAuthToken GetToken();

        /// <summary>
        /// Performs a <see cref="OrbitRequest"/>, injecting the auth header and updating the <see cref="OsuAuthToken"/> if expired/nonexistant
        /// </summary>
        public T Perform<T>(OrbitRequest request, CancellationToken token = default) where T : class
        {
            if (request.ValidateToken)
            {
                if (_token?.Expired != false)
                {
                    _token = GetToken();
                }

                request.WithAuthHeader($"Bearer {_token.AccessToken}");
            }

            return base.Perform<T>(request, token);
        }

        #region v1 Perform Functions

        public IEnumerable<T> Perform<T>(OsuLegacyUserBasedRequest request, CancellationToken token = default) where T : class
        {
            return Perform<IEnumerable<T>>((OsuLegacyRequest)request, token);
        }

        public T Perform<T>(OsuLegacyRequest request, CancellationToken token = default) where T : class
        {
            request.ApiKey = LegacyKey ?? throw new AuthenticationException($"{nameof(LegacyKey)} has no value");
            return base.Perform<T>(request, token);
        }

        #endregion

        #region v2 Auth

        /// <summary>
        /// Performs a <see cref="OsuAuthRequest"/>, injecting the client id and key into the fields if not already filled
        /// </summary>
        public OsuAuthToken Perform(OsuAuthRequest request, CancellationToken token = default)
        {
            return Perform<OsuAuthToken>(request, token);
        }

        /// <summary>
        /// Performs a <see cref="OsuAuthRequest"/>, injecting the client id and key into the fields if not already filled
        /// </summary>
        public T Perform<T>(OsuAuthRequest request, CancellationToken token = default) where T : class
        {
            request.ClientId ??= ClientId ?? throw new NullReferenceException($"{nameof(ClientId)} is not set.");
            request.ClientSecret ??= ClientSecret ?? throw new NullReferenceException($"{nameof(ClientSecret)} is not set.");

            return base.Perform<T>(request, token);
        }

        #endregion

        protected sealed override HttpMessageHandler CreateHandler()
        {
            var handler = base.CreateHandler();

            if (handler == null)
            {
                return new HeaderPreservingRedirectHandler();
            }

            // we need to wrap the handler in a header preservation handler because of user lookup redirs
            return handler is HeaderPreservingRedirectHandler ? handler : new HeaderPreservingRedirectHandler(handler);
        }

        protected override T ValidateAndProcess<T>(HttpResponseMessage response, HttpRequestMessage request) => response.StatusCode switch
        {
            HttpStatusCode.NoContent => default,
            // todo add others/error message

            _ => base.ValidateAndProcess<T>(response, request)
        };

        /// <summary>
        /// Signals to the client the token should be reset
        /// </summary>
        protected internal void InvalidateToken() => _token = null;
    }
}
