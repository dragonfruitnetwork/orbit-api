// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Ecosystem.Entities;
using DragonFruit.Orbit.Api.Ecosystem.Enums;
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
            return client.Perform<OsuChangelogDetails>(new OsuChangelogsRequest());
        }

        /// <summary>
        /// Get a summary of all the targets and recent releases
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <returns>Summary of targets and recent releases</returns>
        public static Task<OsuChangelogDetails> GetChangelogsAsync<T>(this T client) where T : OrbitClient
        {
            return client.PerformAsync<OsuChangelogDetails>(new OsuChangelogsRequest());
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
            return client.Perform<OsuChangelogRelease>(new OsuChangelogRequest(target, version));
        }

        /// <summary>
        /// Get the changelogs for a specific release
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="target">The <see cref="ChangelogTarget"/></param>
        /// <param name="version">The version of the <see cref="target"/> to get entries for</param>
        /// <returns>The changelog and the associated changes</returns>
        public static Task<OsuChangelogRelease> GetChangelogEntryAsync<T>(this T client, ChangelogTarget target, string version) where T : OrbitClient
        {
            return client.PerformAsync<OsuChangelogRelease>(new OsuChangelogRequest(target, version));
        }
    }
}
