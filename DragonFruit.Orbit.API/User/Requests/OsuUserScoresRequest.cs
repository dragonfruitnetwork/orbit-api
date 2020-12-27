// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Interfaces;
using DragonFruit.Orbit.Api.User.Enums;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.User.Requests
{
    public class OsuUserScoresRequest : OrbitRequest, IPaginatedByOffset
    {
        private GameMode? _mode;
        private uint? _limit;

        protected override string Stub => $"users/{Id}/scores/{Type.ToExternalValue()}";

        public OsuUserScoresRequest(uint id, UserScoreType type)
        {
            Id = id;
            Type = type;
        }

        public uint Id { get; set; }
        public UserScoreType Type { get; set; }
        public uint Page { get; set; }

        public GameMode? Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                ModeName = value.ToExternalValue();
            }
        }

        [QueryParameter("mode")]
        public string ModeName { get; set; }

        [QueryParameter("include_fails")]
        public bool? IncludeFails { get; set; }

        [QueryParameter("limit")]
        public uint? Limit
        {
            get => _limit ?? DefaultLimit;
            set => _limit = value;
        }

        [QueryParameter("offset")]
        // ReSharper disable once PossibleInvalidOperationException
        public uint Offset => Page * Limit.Value;
    }
}
