// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data;
using DragonFruit.Orbit.API.Objects.Changelogs;
using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Requests;

namespace DragonFruit.Orbit.API.Extensions
{
    public static class OsuChangelogExtensions
    {
        /// <summary>
        /// Get osu! changelogs from recent releases
        /// </summary>
        /// <param name="client">The <see cref="ApiClient"/> to use</param>
        public static OsuChangelogIndex GetChangelog(this ApiClient client)
        {
            return client.Perform<OsuChangelogIndex>(new OsuChangelogRequest());
        }

        /// <summary>
        /// Get osu! changelogs for a specific version
        /// </summary>
        /// <param name="client">The <see cref="ApiClient"/> to use</param>
        /// <param name="stream">The <see cref="OsuChangelogStream"/> the <see cref="version"/> is associated with</param>
        /// <param name="version">The version to get the changelog for</param>
        public static OsuChangelogRelease GetChangelog(this ApiClient client, OsuChangelogStream stream, string version)
        {
            var request = new OsuChangelogRequest(stream, version);
            return client.Perform<OsuChangelogRelease>(request);
        }
    }
}
