// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Scoring.Enums;
using DragonFruit.Orbit.API.Users.Interfaces;

namespace DragonFruit.Orbit.API.Users.Requests
{
    public class OsuUserScoresRequest : OrbitApiRequest, IRequiresUserId
    {
        public override string Path => $"https://osu.ppy.sh/api/v2/users/{UserId}/scores/{Type}";

        public OsuUserScoresRequest(uint userId, ScoreType type)
        {
            UserId = userId;
            Type = type;
        }

        public uint UserId { get; set; }

        public ScoreType Type { get; set; }
    }
}
