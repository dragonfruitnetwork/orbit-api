// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Utils;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    public class OsuChangelogTarget
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("name")]
        [JsonConverter(typeof(ExternalEnumConverter))]
        public ChangelogTarget Target { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("user_count")]
        public uint? Users { get; set; }

        [CanBeNull]
        [JsonProperty("latest_build")]
        public OsuChangelogRelease LatestRelease { get; set; }
    }
}
