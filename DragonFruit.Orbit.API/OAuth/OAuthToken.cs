// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.OAuth
{
    public class OAuthToken
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public uint ExpiresIn { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("expiry")]
        public DateTimeOffset? Expiry { get; set; }

        [JsonIgnore]
        public bool Expired => DateTimeOffset.Compare(DateTimeOffset.Now, Expiry.GetValueOrDefault()) > 0;

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            if (Expiry != null)
            {
                Expiry = DateTimeOffset.Now.AddSeconds(ExpiresIn);
            }
        }
    }
}
