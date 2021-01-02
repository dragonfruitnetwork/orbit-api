// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Utils;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuChangelogTarget
    {
        private string _targetName;

        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("name")]
        public string TargetName
        {
            get => _targetName;
            set
            {
                _targetName = value;
                Target = EnumUtils.GetInternalValue<ChangelogTarget>(value);
            }
        }

        public ChangelogTarget? Target { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("user_count")]
        public int? Users { get; set; }

        [CanBeNull]
        [JsonProperty("latest_build")]
        public OsuChangelogRelease LatestRelease { get; set; }
    }
}
