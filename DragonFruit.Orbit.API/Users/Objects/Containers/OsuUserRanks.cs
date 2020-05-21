// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Users.Objects.Containers
{
    public class OsuUserRanks
    {
        [JsonProperty("global")]
        public int? Global;

        [JsonProperty("country")]
        public int? Country;
    }
}
