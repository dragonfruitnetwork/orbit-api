// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;

namespace DragonFruit.Orbit.Api.Auth.Requests
{
    public class OsuSessionInvalidationRequest : OrbitRequest
    {
        public override string Path => $"{OrbitClient.BaseEndpoint}/oauth/tokens/current";
        protected override Methods Method => Methods.Delete;

        protected override string Stub => null;
    }
}
