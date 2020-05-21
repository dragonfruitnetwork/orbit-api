// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Linq;
using DragonFruit.Orbit.API.Users.Enums;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Users.Objects.Containers
{
    public class KudosuHistory
    {
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt;

        [JsonProperty("amount")]
        public int Amount;

        [JsonProperty("post")]
        public ModdingPost Post;

        [JsonProperty("giver")]
        public KudosuGiver Giver;

        public KudosuSource Source;

        public KudosuAction Action;

        [JsonProperty("action")]
        private string ActionInfo
        {
            set
            {
                string[] split = value.Split('.');

                if (split.Length > 1)
                    Enum.TryParse(split.First().Replace("_", ""), true, out Source);
                else
                    Source = KudosuSource.Forum;

                Enum.TryParse(split.Last(), true, out Action);
            }
        }
    }
}
