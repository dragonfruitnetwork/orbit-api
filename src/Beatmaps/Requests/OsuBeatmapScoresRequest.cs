// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Beatmaps.Enums;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Beatmaps.Requests
{
    public class OsuBeatmapScoresRequest : OrbitRequest
    {
        protected override string Stub => $"beatmaps/{Id}/scores";

        public OsuBeatmapScoresRequest(uint id)
        {
            Id = id;
        }

        public uint Id { get; }

        public GameMode? Mode { get; set; }
        public BeatmapLeaderboardType? Type { get; set; }

        [QueryParameter("mods", CollectionConversionMode.Unordered)]
        public IEnumerable<string> Mods { get; set; }

        [QueryParameter("type")]
        protected string TypeName => Type.ToExternalValue();
    }
}
