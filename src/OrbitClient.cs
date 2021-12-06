// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Extensions;
using DragonFruit.Common.Data.Serializers;
using DragonFruit.Orbit.Api.Auth;
using Nito.AsyncEx;

namespace DragonFruit.Orbit.Api
{
    public abstract class OrbitClient : ApiClient<ApiJsonSerializer>
    {
        private OsuAuthToken _token;

        /// <summary>
        /// Base endpoint all <see cref="OrbitRequest"/>s are sent to.
        /// This property is static and is used regardless of the client instance
        /// </summary>
        /// <remarks>
        /// Can be changed to use another server but is not recommended
        /// </remarks>
        public static string BaseEndpoint { get; set; } = "https://osu.ppy.sh";

        /// <summary>
        /// Synchronisation object for ensuring authenticated requests perform in an orderly fashion
        /// </summary>
        internal AsyncLock TokenLock { get; } = new AsyncLock();

        /// <summary>
        /// Optional flag to allow <see cref="HttpStatusCode.NotFound"/> to return null instead of an exception
        /// </summary>
        protected virtual bool ThrowNotFound => false;

        /// <summary>
        /// Legacy api key to use with v1 requests
        /// </summary>
        protected internal virtual string LegacyKey => null;

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
        protected internal void PrepareRequest(OrbitRequest request)
        {
            if (!request.IncludeToken)
            {
                return;
            }

            using (TokenLock.Lock())
            {
                if (_token == null || _token.Expired)
                {
                    _token = GetToken();
                }
            }

            request.WithAuthHeader($"Bearer {_token.AccessToken}");
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
