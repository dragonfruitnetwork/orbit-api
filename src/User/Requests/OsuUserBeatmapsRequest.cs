// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.User.Enums;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.User.Requests
{
    public class OsuUserBeatmapsRequest : OrbitOffsetPaginatedRequest
    {
        private uint? _limit;

        protected override string Stub => $"users/{Id}/beatmapsets/{Type.ToExternalValue()}";

        public OsuUserBeatmapsRequest(uint id, UserBeatmapType type)
        {
            Id = id;
            Type = type;
        }

        public uint Id { get; set; }
        public UserBeatmapType Type { get; set; }
    }
}
