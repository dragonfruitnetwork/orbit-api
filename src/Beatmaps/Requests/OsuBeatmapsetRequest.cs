// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Exceptions;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.Api.Beatmaps.Requests
{
    public class OsuBeatmapsetRequest : OrbitRequest
    {
        protected override string Stub
        {
            get
            {
                if (Id.HasValue)
                {
                    return $"beatmapsets/{Id}";
                }

                if (ChildMapId.HasValue)
                {
                    return "beatmapsets/lookup";
                }

                throw new NullRequestException();
            }
        }

        public uint? Id { get; set; }

        [QueryParameter("beatmap_id")]
        public uint? ChildMapId { get; set; }
    }
}
