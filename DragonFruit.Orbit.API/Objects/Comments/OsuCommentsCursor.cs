// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Comments
{
    public class OsuCommentsCursor
    {
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("id")]
        public uint Id { get; set; }
    }
}
