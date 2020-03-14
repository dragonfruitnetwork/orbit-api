// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Users
{
    public class UserHistoryCount
    {
        [JsonProperty("start_date")]
        public DateTime Date { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }
    }
}
