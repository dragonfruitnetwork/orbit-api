// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.Interfaces;

#nullable enable

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuUserScoresRequest : OrbitApiRequest, IRequiresUserId, IHasOptionalMode
    {
        protected override string Route => $"/users/{UserId}/scores/{Type.ToString().ToLowerInvariant()}";

        public OsuUserScoresRequest(uint userId, OsuUserScoreType type)
        {
            UserId = userId;
            Type = type;
        }

        public OsuUserScoresRequest(uint userId, OsuUserScoreType type, GameMode mode)
            : this(userId, type)
        {
            Mode = mode;
        }

        public uint UserId { get; set; }
        public OsuUserScoreType Type { get; set; }
        public GameMode? Mode { get; set; }

        [QueryParameter("include_fails")]
        public bool? IncludeFails { get; set; }

        [QueryParameter("mode")]
        private string? ModeQuery => Mode.ToQueryableValue();
    }
}
