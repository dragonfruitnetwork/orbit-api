// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DragonFruit.Common.Data;
using DragonFruit.Orbit.API.Legacy.Requests;
using DragonFruit.Orbit.API.OAuth;

namespace DragonFruit.Orbit.API
{
    public abstract class OrbitClient : ApiClient
    {
        protected abstract OAuthToken GetToken();

        #region Legacy Requests

        /// <summary>
        /// Global Legacy API key, can be obtained from https://old.ppy.sh/p/api
        /// </summary>
        protected virtual string LegacyApiToken { get; }

        /// <summary>
        /// Performs legacy requests, returning them as an <see cref="IEnumerable{T}"/>. If <see cref="LegacyRequestBase.ApiKey"/> is null the <see cref="LegacyApiToken"/> will be used instead
        /// </summary>
        public IEnumerable<T> Perform<T>(LegacyRequestBase requestData) where T : class
        {
            if (string.IsNullOrEmpty(requestData.ApiKey))
                requestData.ApiKey = LegacyApiToken;

            return base.Perform<IEnumerable<T>>(requestData);
        }

        public T Perform<T>(LegacyMultiplayerMatchRequest requestData) where T : class
        {
            if (string.IsNullOrEmpty(requestData.ApiKey))
                requestData.ApiKey = LegacyApiToken;

            return base.Perform<T>(requestData);
        }

        #endregion

        /// <summary>
        /// Performs a <see cref="OAuthRequest"/>, returning the <see cref="OAuthToken"/> is successful
        /// </summary>
        public OAuthToken Perform<T>(T requestData) where T : OAuthRequest
        {
            return base.Perform<OAuthToken>(requestData);
        }

        public override T Perform<T>(ApiRequest requestData)
        {
            if (_token == null)
                ProcessToken();

            if (_token.Expired)
                ProcessToken();

            return base.Perform<T>(requestData);
        }

        protected override T ValidateAndProcess<T>(Task<HttpResponseMessage> response) where T : class
        {
            switch (response.Result.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                    throw new Exception("Token has expired");

                //todo add more status codes
            }

            return base.ValidateAndProcess<T>(response);
        }

        #region OAuth2 Token (Private)

        private void ProcessToken()
        {
            _token = GetToken();
            Authorization = $"{_token.TokenType} {_token.AccessToken}";
        }

        private OAuthToken _token;

        #endregion
    }
}
