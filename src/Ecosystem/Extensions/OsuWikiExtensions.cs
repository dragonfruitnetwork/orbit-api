// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Threading.Tasks;
using DragonFruit.Orbit.Api.Ecosystem.Entities;
using DragonFruit.Orbit.Api.Ecosystem.Requests;

namespace DragonFruit.Orbit.Api.Ecosystem.Extensions
{
    public static class OsuWikiExtensions
    {
        /// <summary>
        /// Gets a specified wiki page with choice of language
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="locale">The language to return the content in</param>
        /// <param name="path">The relative path to the entry</param>
        public static Task<OsuWikiPage> GetWikiPage(this OrbitClient client, string path, string locale = "en")
        {
            var request = new OsuWikiPageRequest(locale, path);
            return client.PerformAsync<OsuWikiPage>(request);
        }
    }
}
