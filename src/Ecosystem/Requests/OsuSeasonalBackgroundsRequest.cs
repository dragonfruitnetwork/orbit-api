// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.Api.Ecosystem.Requests
{
    public class OsuSeasonalBackgroundsRequest : OrbitRequest
    {
        protected override string Stub => "seasonal-backgrounds";

        protected override bool RequireAuth => false;
    }
}
