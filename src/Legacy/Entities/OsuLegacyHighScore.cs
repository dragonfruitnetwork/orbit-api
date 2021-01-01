// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.Legacy.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Legacy.Entities
{
    [Serializable]
    public class OsuLegacyHighScore : OsuLegacyScore
    {
        [JsonProperty("score_id")]
        public ulong ScoreId { get; set; }

        [JsonProperty("pp")]
        public float PP { get; set; }

        [JsonProperty("replay_available")]
        public LegacyBool ReplayAvailable { get; set; }
    }
}
