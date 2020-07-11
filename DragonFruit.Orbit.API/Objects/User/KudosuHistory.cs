// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Linq;
using DragonFruit.Orbit.API.Objects.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Objects.User
{
    public class KudosuHistory
    {
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("post")]
        public OsuModdingPost Post { get; set; }

        [JsonProperty("giver")]
        public KudosuGiver Giver { get; set; }

        public KudosuSource Source => _source;

        public KudosuAction Action => _action;

        [JsonProperty("action")]
        private string ActionInfo
        {
            set
            {
                var items = value.Split('.');

                if (items.Length > 1)
                {
                    Enum.TryParse(items.First().Replace("_", ""), true, out _source);
                }
                else
                {
                    _source = KudosuSource.Forum;
                }

                Enum.TryParse(items.Last(), true, out _action);
            }
        }

        private KudosuSource _source;
        private KudosuAction _action;
    }
}
