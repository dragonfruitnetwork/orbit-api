// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.Generic
{
    /// <summary>
    /// Object used for tracking what items have been sent, i.e. a page number
    /// </summary>
    public class Cursor
    {
        [JsonProperty("page")]
        public int Page { get; set; }
    }
}
