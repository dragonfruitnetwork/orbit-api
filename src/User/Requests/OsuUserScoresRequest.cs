// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Interfaces;
using DragonFruit.Orbit.Api.User.Enums;
using DragonFruit.Orbit.Api.Utils;
using JetBrains.Annotations;

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
        public bool IncludeFails { get; set; }

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

        [NotNull]
        [QueryParameter("limit")]
        public uint? Limit
        {
            get => _limit ?? DefaultLimit;
            set => _limit = value;
        }

        [QueryParameter("include_fails")]
        protected string IncludeFailsValue
        {
            get
            {
                if (Type == UserScoreType.Recent)
                {
                    return IncludeFails ? "1" : "0";
                }

                return null;
            }
        }

        [QueryParameter("offset")]
        public uint Offset => Page * Limit.Value;
    }
}
