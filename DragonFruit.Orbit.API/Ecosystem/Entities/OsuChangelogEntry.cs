// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    public class OsuChangelogEntry
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [CanBeNull]
        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("github_pull_request_id")]
        public uint? GitHubId { get; set; }

        [CanBeNull]
        [JsonProperty("github_url")]
        public string GitHubUrl { get; set; }

        [CanBeNull]
        [JsonProperty("url")]
        public string Url { get; set; }

        // todo convert to enum
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [CanBeNull]
        [JsonProperty("message_html")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("major")]
        public bool IsMajor { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("github_user")]
        private OsuChangelogEntryAuthor Author { get; set; }
    }
}
