// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Interfaces;
using DragonFruit.Orbit.Api.User.Enums;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.User.Requests
{
    public class OsuUserBeatmapsRequest : OrbitRequest, IPaginatedByOffset
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

        public uint Page { get; set; }

        [QueryParameter("limit")]
        public uint? Limit
        {
            get => _limit ?? DefaultLimit;
            set => _limit = value;
        }

        // ReSharper disable once PossibleInvalidOperationException
        [QueryParameter("offset")]
        public uint Offset => Page * Limit.Value;
    }
}
