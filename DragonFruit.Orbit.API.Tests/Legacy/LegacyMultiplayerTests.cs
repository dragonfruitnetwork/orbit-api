// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Legacy.Objects;
using DragonFruit.Orbit.API.Legacy.Requests;
using NUnit.Framework;

namespace DragonFruit.Orbit.API.Tests.Legacy
{
    [TestFixture]
    public class LegacyMultiplayerTests : OrbitTestBase
    {
        [TestCase(64113963u)]
        public void TestMultiplayerLobbyStats(uint lobbyId)
        {
            var request = new LegacyMultiplayerMatchRequest(lobbyId);
            Client.Perform<LegacyMultiplayerMatch>(request);
        }
    }
}
