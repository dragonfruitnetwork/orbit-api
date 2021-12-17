// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Data;
using DragonFruit.Data.Parameters;

namespace DragonFruit.Orbit.Api.Auth.Requests
{
    public abstract class OsuAuthRequest : ApiRequest
    {
        public override string Path => $"{OrbitClient.BaseEndpoint}/oauth/token";

        protected override Methods Method => Methods.Post;
        protected override BodyType BodyType => BodyType.Encoded;

        [FormParameter("client_id")]
        public string ClientId { get; set; }

        [FormParameter("client_secret")]
        public string ClientSecret { get; set; }

        [FormParameter("grant_type")]
        public abstract string GrantType { get; }

        protected override void OnRequestExecuting(ApiClient client)
        {
            if (client is OrbitClient orbit)
            {
                ClientId ??= orbit.ClientId ?? throw new NullReferenceException($"{nameof(ClientId)} is not set.");
                ClientSecret ??= orbit.ClientSecret ?? throw new NullReferenceException($"{nameof(ClientSecret)} is not set.");
            }
        }
    }
}
