// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Runtime.Serialization;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Auth
{
    [Serializable]
    public class OsuAuthToken
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public uint ExpiresIn { get; set; }

        [JsonProperty("expiry_date")]
        public DateTimeOffset? Expiry { get; set; }

        [CanBeNull]
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonIgnore]
        public bool Expired => Expiry <= DateTimeOffset.Now;

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            // if we don't have an expiry, set one from the ExpiresIn property
            Expiry ??= DateTimeOffset.Now.AddSeconds(ExpiresIn);
        }
    }
}
