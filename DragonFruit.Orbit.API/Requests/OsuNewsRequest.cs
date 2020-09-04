// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuNewsRequest : OrbitApiRequest
    {
        protected override string Route => "/news";
        protected override bool RequireAuth => false;
    }
}
