// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Orbit.API.Objects.Beatmaps;
using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.User;
using DragonFruit.Orbit.API.Requests;

namespace DragonFruit.Orbit.API.Extensions
{
    public static class OsuUserExtensions
    {
        /// <summary>
        /// Get the authorising users' profile and info (publically accessible)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        public static OsuUser GetCurrentUser(this OrbitClient client) => client.Perform<OsuUser>(new OsuUserRequest());

        /// <summary>
        /// Get the authorising users' friend list
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <returns>an <see cref="IEnumerable{T}"/> of condensed <see cref="OsuUser"/>s</returns>
        public static IEnumerable<OsuCondensedUser> GetFriends(this OrbitClient client) => client.Perform<IEnumerable<OsuCondensedUser>>(new OsuUserFriendsRequest());

        #region Non-Authenticating User Lookup

        /// <summary>
        /// Get a user's favourite mode profile info from their id or username
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="user">The username/id of the user to lookup</param>
        public static OsuUser GetUser(this OrbitClient client, string user)
        {
            var request = new OsuUserRequest(user);
            return client.Perform<OsuUser>(request);
        }

        /// <summary>
        /// Get a user's profile info from their id
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="user">The username/id of the user to lookup</param>
        /// <param name="mode">Optional <see cref="GameMode"/> to return data for</param>
        public static OsuUser GetUser(this OrbitClient client, string user, GameMode? mode)
        {
            var request = new OsuUserRequest
            {
                UserId = user,
                Mode = mode
            };

            return client.Perform<OsuUser>(request);
        }

        #endregion

        #region User Activity

        /// <summary>
        /// Get a user's recent activity entries (modding, scores, supporter, etc.)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="userId">The id of the user to lookup</param>
        public static IEnumerable<OsuUserRecentActivity> GetRecentActivity(this OrbitClient client, uint userId)
        {
            return GetRecentActivity(client, userId, 0);
        }

        /// <summary>
        /// Get a user's recent activity entries (modding, scores, supporter, etc.)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="userId">The id of the user to lookup</param>
        /// <param name="page">The page number to return results for</param>
        public static IEnumerable<OsuUserRecentActivity> GetRecentActivity(this OrbitClient client, uint userId, uint page)
        {
            var request = new OsuUserRecentActivityRequest(userId, page);
            return client.Perform<IEnumerable<OsuUserRecentActivity>>(request);
        }

        #endregion

        #region User Scores

        /// <summary>
        /// Get a user's scores (i.e. highest/recent) for their preferred mode
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="userId">The id of the user to lookup</param>
        /// <param name="type">The <see cref="OsuUserScoreType"/> to return scores for</param>
        public static IEnumerable<OsuUserScoreInfo> GetUserScores(this OrbitClient client, uint userId, OsuUserScoreType type)
        {
            return GetUserScores(client, userId, null, type, 0, false);
        }

        /// <summary>
        /// Get a user's scores (i.e. highest/recent)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="userId">The id of the user to lookup</param>
        /// <param name="type">The <see cref="OsuUserScoreType"/> to return scores for</param>
        /// <param name="mode">The <see cref="GameMode"/> to return scores for</param>
        /// <param name="includeRecentFails">If <see cref="OsuUserScoreType"/> is set to Recents, whether the API should include failed performances and quits</param>
        public static IEnumerable<OsuUserScoreInfo> GetUserScores(this OrbitClient client, uint userId, GameMode? mode, OsuUserScoreType type, bool? includeRecentFails)
        {
            return GetUserScores(client, userId, mode, type, 0, includeRecentFails);
        }

        /// <summary>
        /// Get a user's scores (i.e. highest/recent)
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="userId">The id of the user to lookup</param>
        /// <param name="type">The <see cref="OsuUserScoreType"/> to return scores for</param>
        /// <param name="mode">The <see cref="GameMode"/> to return scores for</param>
        /// <param name="page">The page number to return results for</param>
        /// <param name="includeRecentFails">If <see cref="OsuUserScoreType"/> is set to Recents, whether the API should include failed performances and quits</param>
        public static IEnumerable<OsuUserScoreInfo> GetUserScores(this OrbitClient client, uint userId, GameMode? mode, OsuUserScoreType type, uint page, bool? includeRecentFails)
        {
            var request = new OsuUserScoresRequest(userId, type)
            {
                IncludeFails = includeRecentFails,
                Mode = mode,
                Page = page
            };

            return client.Perform<IEnumerable<OsuUserScoreInfo>>(request);
        }

        #endregion

        #region Kudosu History

        /// <summary>
        /// Get a user's kudosu history
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="userId">The id of the user to lookup</param>
        public static IEnumerable<KudosuHistory> GetKudosuHistory(this OrbitClient client, uint userId)
        {
            return GetKudosuHistory(client, userId, 0);
        }

        /// <summary>
        /// Get a user's kudosu history
        /// </summary>
        /// <param name="client">The <see cref="OrbitClient"/> to use</param>
        /// <param name="userId">The id of the user to lookup</param>
        /// <param name="page">The page to return results for</param>
        public static IEnumerable<KudosuHistory> GetKudosuHistory(this OrbitClient client, uint userId, uint page)
        {
            var request = new OsuUserKudosuRequest(userId, page);
            return client.Perform<IEnumerable<KudosuHistory>>(request);
        }

        #endregion

        #region User Beatmapsets

        /// <summary>
        /// Get beatmaps the specified user has authored, based on their ranked status
        /// </summary>
        /// <param name="client"><see cref="OrbitClient"/> to use</param>
        /// <param name="userId">The id of the user authoring the maps</param>
        /// <param name="type">The <see cref="OsuUserBeatmapsetStatus"/> to find maps for</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="OsuBeatmapInfo"/>s</returns>
        public static IEnumerable<OsuBeatmapsetInfo> GetUserBeatmapsets(this OrbitClient client, uint userId, OsuUserBeatmapsetStatus type)
        {
            return GetUserBeatmapsets(client, userId, type, 0);
        }

        /// <summary>
        /// Get beatmaps the specified user has authored, based on their ranked status
        /// </summary>
        /// <param name="client"><see cref="OrbitClient"/> to use</param>
        /// <param name="userId">The id of the user authoring the maps</param>
        /// <param name="type">The <see cref="OsuUserBeatmapsetStatus"/> to find maps for</param>
        /// <param name="page">The page to return results for</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="OsuBeatmapInfo"/>s</returns>
        public static IEnumerable<OsuBeatmapsetInfo> GetUserBeatmapsets(this OrbitClient client, uint userId, OsuUserBeatmapsetStatus type, uint page)
        {
            var request = new OsuUserBeatmapRequest(userId, type, page);
            return client.Perform<IEnumerable<OsuBeatmapsetInfo>>(request);
        }

        #endregion
    }
}
