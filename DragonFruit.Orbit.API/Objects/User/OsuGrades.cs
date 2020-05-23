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

        public int this[OsuScoreGrade rank]
        {
            get
            {
                switch (rank)
                {
                    case OsuScoreGrade.XH:
                        return SSPlus ?? 0;

                    case OsuScoreGrade.X:
                        return SS;

                    case OsuScoreGrade.SH:
                        return SPlus ?? 0;

                    case OsuScoreGrade.S:
                        return S;

                    case OsuScoreGrade.A:
                        return A;

                    default:
                        throw new ArgumentException($"API does not return {rank.ToString()}");
                }
            }
        }
    }
}
