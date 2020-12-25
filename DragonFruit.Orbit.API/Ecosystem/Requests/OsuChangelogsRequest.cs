// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.Api.Ecosystem.Requests
{
    /// <summary>
    /// Requests the latest changelog updates and target (app) info
    /// </summary>
    public class OsuChangelogsRequest : OrbitRequest
    {
        protected override string Stub => "changelogs";
        protected override bool RequireAuth => false;
    }
}
