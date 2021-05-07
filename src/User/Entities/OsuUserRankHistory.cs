// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.Utils;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.User.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuUserRankHistory
    {
        private string _modeName;

        [JsonProperty("mode")]
        public string ModeName
        {
            get => _modeName;
            set
            {
                _modeName = value;
                Mode = EnumUtils.GetInternalValue<GameMode>(value);
            }
        }

        public GameMode? Mode { get; set; }

        [JsonProperty("data")]
        public int[] Positions { get; set; }
    }
}
