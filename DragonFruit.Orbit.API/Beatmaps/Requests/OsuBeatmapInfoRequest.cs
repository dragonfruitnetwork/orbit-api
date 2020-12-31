// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Beatmaps.Requests
{
    public class OsuBeatmapInfoRequest : OrbitRequest
    {
        protected override string Stub => $"beatmaps/{Id}";

        public OsuBeatmapInfoRequest(uint id)
        {
            Id = id;
        }

        public uint Id { get; set; }
        public GameMode? Mode { get; set; }

        [QueryParameter("mode")]
        protected string ModeName => Mode.ToExternalValue();
    }
}
