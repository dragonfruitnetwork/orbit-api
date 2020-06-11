// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.API.Objects.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Changelogs
{
    public class OsuChangelogEntry
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("github_pull_request_id")]
        public long? GithubPullRequestId { get; set; }

        [JsonProperty("github_url")]
        public string GithubUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public OsuChangelogEntryType Type { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("message_html")]
        public string MessageHtml { get; set; }

        [JsonProperty("major")]
        public bool Major { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("github_user")]
        public OsuChangelogUser GithubUser { get; set; }
    }
}
