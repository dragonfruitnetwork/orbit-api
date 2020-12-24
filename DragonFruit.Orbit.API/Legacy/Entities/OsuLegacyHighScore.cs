// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Legacy.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Legacy.Entities
{
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
