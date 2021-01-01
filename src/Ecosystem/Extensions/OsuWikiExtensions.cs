// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Ecosystem.Entities;
using DragonFruit.Orbit.Api.Ecosystem.Requests;

namespace DragonFruit.Orbit.Api.Ecosystem.Extensions
{
    public static class OsuWikiExtensions
    {
        /// <summary>
        /// Gets the English version of the specified wiki page
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="path">The relative path to the entry</param>
        public static OsuWikiPage GetWikiPage<T>(this T client, string path) where T : OrbitClient
        {
            return client.GetWikiPage("en", path);
        }

        /// <summary>
        /// Gets a specified wiki page with choice of language
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="locale">The language to return the content in</param>
        /// <param name="path">The relative path to the entry</param>
        public static OsuWikiPage GetWikiPage<T>(this T client, string locale, string path) where T : OrbitClient
        {
            var request = new OsuWikiPageRequest(locale, path);
            return client.Perform<OsuWikiPage>(request);
        }
    }
}
