// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Interfaces;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuUserRecentActivityRequest : OrbitPaginatedRequest, IRequiresUserId
    {
        protected override string Route => $"/users/{UserId}/recent_activity";
        protected override bool UsesOffset => true;

        /// <summary>
        /// Get a user's recent activity
        /// </summary>
        public OsuUserRecentActivityRequest(uint userId)
        {
            UserId = userId;
        }

        /// <summary>
        /// Get a specific page of the user's recent activity
        /// </summary>
        public OsuUserRecentActivityRequest(uint userId, uint page)
            : this(userId)
        {
            Page = page;
        }

        public uint UserId { get; set; }
    }
}
