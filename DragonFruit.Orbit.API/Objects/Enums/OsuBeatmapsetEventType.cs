// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;

namespace DragonFruit.Orbit.API.Objects.Enums
{
    public enum OsuBeatmapsetEventType
    {
        IssueResolve,
        KudosuGain,
        Nominate

        //todo find the rest of these...
    }

    public static class OsuBeatmapsetEventTypeExtensions
    {
        public static string ToQueryable(this OsuBeatmapsetEventType type)
        {
            return type switch
            {
                OsuBeatmapsetEventType.IssueResolve => "issue_resolve",
                OsuBeatmapsetEventType.KudosuGain => "kudosu_gain",
                _ => type.ToString().ToLowerInvariant()
            };
        }

        public static OsuBeatmapsetEventType FromQueryable(string input)
        {
            return Enum.Parse<OsuBeatmapsetEventType>(input.Replace("_", string.Empty), true);
        }
    }
}
