// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Interfaces;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuUserKudosuRequest : OrbitPaginatedRequest, IRequiresUserId
    {
        protected override string Route => $"/users/{UserId}/kudosu";
        protected override bool UsesOffset => true;

        /// <summary>
        /// Get a user's kudosu history
        /// </summary>
        public OsuUserKudosuRequest(uint userId)
        {
            UserId = userId;
        }

        /// <summary>
        /// Get a specific page of a user's kudosu history
        /// </summary>
        public OsuUserKudosuRequest(uint userId, uint page)
            : this(userId)
        {
            Page = page;
        }

        public uint UserId { get; set; }
    }
}
