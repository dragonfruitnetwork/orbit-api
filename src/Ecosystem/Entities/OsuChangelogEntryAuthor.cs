// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuChangelogEntryAuthor
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("github_url")]
        public string GitHubUrl { get; set; }

        [JsonProperty("osu_username")]
        public string OsuUsername { get; set; }

        [JsonProperty("user_id")]
        public uint? OsuUserId { get; set; }

        [JsonProperty("user_url")]
        public string UserUrl { get; set; }
    }
}
