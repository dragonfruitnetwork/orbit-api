// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Legacy.Entities
{
    public class OsuLegacyReplayContent
    {
        [JsonProperty("content")]
        public string EncodedContent { get; set; }
    }
}
