// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.Interfaces;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuUserBeatmapRequest : OrbitPaginatedRequest, IRequiresUserId
    {
        private OsuUserBeatmapsetStatus _mapStatus;
        private string _mapStatusString;

        protected override string Route => $"/users/{UserId}/beatmapsets/{_mapStatusString}";
        protected override bool UsesOffset => false;

        /// <summary>
        /// Get a collection of the user's authored beatmaps, based on their ranked status
        /// </summary>
        public OsuUserBeatmapRequest(uint userId, OsuUserBeatmapsetStatus mapStatus)
        {
            UserId = userId;
            MapStatus = mapStatus;
        }

        /// <summary>
        /// Get a specific page of the user's authored beatmaps, based on their ranked status
        /// </summary>
        public OsuUserBeatmapRequest(uint userId, OsuUserBeatmapsetStatus mapStatus, uint page)
            : this(userId, mapStatus)
        {
            Page = page;
        }

        public uint UserId { get; set; }

        public OsuUserBeatmapsetStatus MapStatus
        {
            get => _mapStatus;
            set
            {
                _mapStatus = value;
                _mapStatusString = value switch
                {
                    OsuUserBeatmapsetStatus.RankedAndApproved => "ranked_and_approved",
                    _ => value.ToString().ToLowerInvariant()
                };
            }
        }
    }
}
