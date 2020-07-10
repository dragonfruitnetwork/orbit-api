// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Orbit.API.Exceptions;
using DragonFruit.Orbit.API.Legacy;
using DragonFruit.Orbit.API.Objects.Auth;
using DragonFruit.Orbit.API.Requests;

#nullable enable

namespace DragonFruit.Orbit.API
{
    public abstract class OrbitClient : ApiClient
    {
        protected abstract OsuSessionTokenBase GetSessionToken();

        #region Legacy Requests

        /// <summary>
        /// Global Legacy API key, can be obtained from https://old.ppy.sh/p/api
        /// </summary>
        protected virtual string LegacyApiKey { get; }

        /// <summary>
        /// Performs legacy requests, returning them as an <see cref="IEnumerable{T}"/>.
        /// </summary>
        public IEnumerable<T> Perform<T>(LegacyRequestBase requestData) where T : class
        {
            if (string.IsNullOrEmpty(requestData.ApiKey))
                requestData.ApiKey = LegacyApiKey ?? throw new LegacyApiException("Legacy API Request attempted with no key");

            return base.Perform<IEnumerable<T>>(requestData);
        }

        #endregion

        #region API v2 OAuth

        protected virtual string ClientId { get; }
        protected virtual string ClientSecret { get; }

        /// <summary>
        /// Performs an <see cref="OsuAuthRequest"/>, returning the <see cref="OsuSessionToken"/> if successful
        /// </summary>
        public OsuSessionToken Perform<T>(T requestData) where T : OsuAuthRequest
        {
            //inject the clientid and secret if they haven't been set
            if (string.IsNullOrEmpty(requestData.ClientSecret))
            {
                requestData.ClientId = ClientId;
                requestData.ClientSecret = ClientSecret;
            }

            //bypass the _token checks as we're getting them now...
            return base.Perform<OsuSessionToken>(requestData);
        }

        #endregion

        #region API v2 Auth

        private void ProcessToken()
        {
            _token = GetSessionToken();
            Authorization = $"{_token!.TokenType} {_token.AccessToken}";
        }

        private OsuSessionTokenBase? _token;

        #endregion

        public T Perform<T>(OrbitApiRequest requestData) where T : class
        {
            if (_token?.Expired ?? true)
            {
                ProcessToken();
            }

            return base.Perform<T>(requestData);
        }

        protected override T ValidateAndProcess<T>(Task<HttpResponseMessage> response) where T : class
        {
            switch (response.Result.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                    throw new TokenExpiredException(_token);

                //todo add more status codes
            }

            return base.ValidateAndProcess<T>(response);
        }
    }
}
