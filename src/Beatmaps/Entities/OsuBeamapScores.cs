// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using DragonFruit.Orbit.Api.Ranking.Entities;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Beatmaps.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuBeamapScores
    {
        [JsonProperty("scores")]
        public IEnumerable<OsuScore> Scores { get; set; }

        [CanBeNull]
        [JsonProperty(@"userScore")]
        public OsuUserBestScore UserBest { get; set; }
    }
}
