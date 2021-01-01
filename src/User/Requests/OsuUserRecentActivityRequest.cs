// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.Api.User.Requests
{
    public class OsuUserRecentActivityRequest : OrbitOffsetPaginatedRequest
    {
        private uint? _limit;

        protected override string Stub => $"users/{Id}/recent_activity";

        public OsuUserRecentActivityRequest(uint id)
        {
            Id = id;
        }

        public uint Id { get; set; }
    }
}
