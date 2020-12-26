// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Ecosystem.Requests
{
    /// <summary>
    /// Requests the changelog info for a specific changelog entry
    /// </summary>
    public class OsuChangelogRequest : OrbitRequest
    {
        protected override string Stub => $"changelog/{Target.ToExternalValue()}/{Version}";
        protected override bool RequireAuth => false;

        public OsuChangelogRequest(ChangelogTarget target, string version)
        {
            Target = target;
            Version = version;
        }

        public ChangelogTarget Target { get; set; }
        public string Version { get; set; }
    }
}
