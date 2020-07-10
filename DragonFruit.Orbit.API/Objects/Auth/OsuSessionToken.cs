// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Auth
{
    public class OsuSessionToken : OsuSessionTokenBase
    {
        [JsonProperty("expires_in")]
        public uint ExpiresIn { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            Expiry ??= DateTimeOffset.Now.AddSeconds(ExpiresIn);
        }
    }
}
