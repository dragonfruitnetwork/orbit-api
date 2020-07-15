// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.API.Tests
{
    public abstract class OrbitTestBase
    {
        private OrbitClient _client;

        protected OrbitClient Client => _client ??= new OrbitTestClient();
    }
}
