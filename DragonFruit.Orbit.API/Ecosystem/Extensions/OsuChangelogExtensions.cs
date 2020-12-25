// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Ecosystem.Entities;
using DragonFruit.Orbit.Api.Ecosystem.Enum;
using DragonFruit.Orbit.Api.Ecosystem.Requests;

namespace DragonFruit.Orbit.Api.Ecosystem.Extensions
{
    public static class OsuChangelogExtensions
    {
        /// <summary>
        /// Get a summary of all the targets and recent releases
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <returns>Summary of targets and recent releases</returns>
        public static OsuChangelogDetails GetChangelogs<T>(this T client) where T : OrbitClient
        {
            var request = new OsuChangelogsRequest();
            return client.Perform<OsuChangelogDetails>(request);
        }

        /// <summary>
        /// Get the changelogs for a specific release
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="target">The <see cref="ChangelogTarget"/></param>
        /// <param name="version">The version of the <see cref="target"/> to get entries for</param>
        /// <returns>The changelog and the associated changes</returns>
        public static OsuChangelogRelease GetChangelogEntry<T>(this T client, ChangelogTarget target, string version) where T : OrbitClient
        {
            var request = new OsuChangelogRequest(target, version);
            return client.Perform<OsuChangelogRelease>(request);
        }
    }
}
