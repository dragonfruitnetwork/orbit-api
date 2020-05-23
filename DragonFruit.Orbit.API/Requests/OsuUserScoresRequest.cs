// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.Interfaces;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuUserScoresRequest : OrbitApiRequest, IRequiresUserId
    {
        public override string Path => $"https://osu.ppy.sh/api/v2/users/{UserId}/scores/{Type}";

        public OsuUserScoresRequest(uint userId, OsuUserScoreType type)
        {
            UserId = userId;
            Type = type;
        }

        public uint UserId { get; set; }

        public OsuUserScoreType Type { get; set; }
    }
}
