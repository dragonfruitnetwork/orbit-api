// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DragonFruit.Orbit.Api.Legacy.Entities;
using DragonFruit.Orbit.Api.Legacy.Requests;

namespace DragonFruit.Orbit.Api.Legacy.Extensions
{
    public static class OsuLegacyUserExtensions
    {
        /// <summary>
        /// Get a user's info for the specified mode (defaults to osu!standard)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use for the request</param>
        /// <param name="identifier">The identifier (numeric or username)</param>
        /// <param name="mode">The <see cref="GameMode"/> to get stats for</param>
        /// <param name="isUsername">Whether the <see cref="identifier"/> was a username</param>
        /// <param name="token">A <see cref="CancellationToken"/> that can be used to stop the request</param>
        /// <returns>A <see cref="OsuLegacyUser"/> if there was one, otherwise a null response</returns>
        public static OsuLegacyUser GetLegacyUser<T>(this T client, string identifier, GameMode? mode = null, bool? isUsername = null, CancellationToken token = default)
            where T : OrbitClient
        {
            var request = new OsuLegacyUserRequest(identifier)
            {
                IsIdentifierUsername = isUsername,
                Mode = mode ?? GameMode.Standard
            };

            // the array should only return a single item.
            return client.Perform<IEnumerable<OsuLegacyUser>>(request, token).SingleOrDefault();
        }
    }
}
