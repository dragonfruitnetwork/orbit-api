// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.API.Objects.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.User
{
    public class OsuGrades
    {
        [JsonProperty("ssh")]
        public int? SSPlus { get; set; }

        [JsonProperty("ss")]
        public int SS { get; set; }

        [JsonProperty("sh")]
        public int? SPlus { get; set; }

        [JsonProperty("s")]
        public int S { get; set; }

        [JsonProperty("a")]
        public int A { get; set; }

        public int NumberOf(OsuScoreGrade rank) =>
            rank switch
            {
                OsuScoreGrade.XH => SSPlus ?? 0,
                OsuScoreGrade.X => SS,
                OsuScoreGrade.SH => SPlus ?? 0,
                OsuScoreGrade.S => S,
                OsuScoreGrade.A => A,
                _ => throw new ArgumentException($"API does not return {rank.ToString()}")
            };
    }
}
