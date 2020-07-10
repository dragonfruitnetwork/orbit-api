// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Auth
{
    public class OsuSessionTokenBase
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expiry")]
        public DateTimeOffset? Expiry { get; set; }

        [JsonIgnore]
        public bool Expired => DateTimeOffset.Compare(DateTimeOffset.Now, Expiry.GetValueOrDefault()) >= 0;
    }
}
