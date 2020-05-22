// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.User;
using DragonFruit.Orbit.API.Requests;

namespace DragonFruit.Orbit.API.Extensions
{
    public static class OsuUsersExtensions
    {
        public static OsuUser GetCurrentUser(this OrbitClient client) => client.Perform<OsuUser>(new OsuUserRequest());

        public static IEnumerable<OsuUser> GetFriends(this OrbitClient client) => client.Perform<IEnumerable<OsuUser>>(new OsuUserFriendsRequest());

        public static OsuUser GetUser(this OrbitClient client, uint userId)
        {
            var request = new OsuUserRequest(userId);
            return client.Perform<OsuUser>(request);
        }

        public static IEnumerable<OsuUserRecentActivity> GetRecentActivity(this OrbitClient client, uint userId)
        {
            var request = new OsuUserRecentActivityRequest(userId);
            return client.Perform<IEnumerable<OsuUserRecentActivity>>(request);
        }

        public static IEnumerable<OsuUserScoreInfo> GetUserScores(this OrbitClient client, uint userId, ScoreType type)
        {
            var request = new OsuUserScoresRequest(userId, type);
            return client.Perform<IEnumerable<OsuUserScoreInfo>>(request);
        }

        public static IEnumerable<KudosuHistory> GetKudosuHistory(this OrbitClient client, uint userId)
        {
            var request = new OsuUserKudosuRequest(userId);
            return client.Perform<IEnumerable<KudosuHistory>>(request);
        }
    }
}
