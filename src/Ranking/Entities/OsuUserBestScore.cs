// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ranking.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuUserBestScore
    {
        [JsonProperty("position")]
        public uint? Position { get; set; }

        [JsonProperty("score")]
        public OsuScore Score { get; set; }
    }
}
