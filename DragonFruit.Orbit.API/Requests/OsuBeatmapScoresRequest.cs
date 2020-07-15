// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Objects.Enums;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuBeatmapScoresRequest : OrbitApiRequest
    {
        protected override string Route => $"/beatmaps/{BeatmapId}/scores";

        /// <summary>
        /// Get a beatmaps' leaderboard based on the game mode and leaderboard type. (An <see cref="IEnumerable{T}"/> of mod acronyms can be passed as well)
        ///
        /// <para>
        /// The Country and Friend leaderboards are only accessible by authenticating users with a valid supporter tag
        /// </para>
        /// </summary>
        public OsuBeatmapScoresRequest(uint mapId, GameMode mode, BeatmapLeaderboardScope type)
        {
            BeatmapId = mapId;
            Mode = mode;
            Type = type;
        }

        public uint BeatmapId { get; set; }
        public GameMode? Mode { get; set; }
        public BeatmapLeaderboardScope Type { get; set; }
        public IEnumerable<string>? Mods { get; set; }

        #region Compiled Queries

        [QueryParameter("mode")]
        private string ModeQuery => Mode.ToQueryableValue();

        [QueryParameter("type")]
        private string TypeQuery => Type.ToString().ToLowerInvariant();

        [QueryParameter("mods[]")]
        private string CompiledModsQuery => Mods == null ? null : string.Join("&mods[]=", Mods);

        #endregion
    }
}
