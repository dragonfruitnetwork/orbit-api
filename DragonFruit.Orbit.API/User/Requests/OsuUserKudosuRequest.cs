// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Interfaces;

namespace DragonFruit.Orbit.Api.User.Requests
{
    public class OsuUserKudosuRequest : OrbitRequest, IPaginatedByOffset
    {
        private uint? _limit;

        protected override string Stub => $"users/{Id}/kudosu";

        public OsuUserKudosuRequest(uint id)
        {
            Id = id;
        }

        public uint Id { get; set; }
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
