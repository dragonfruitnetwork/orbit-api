// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Linq;
using DragonFruit.Orbit.Api.User.Enums;
using DragonFruit.Orbit.Api.Utils;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.User.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuKudosuHistory
    {
        private string _actionName;

        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("action")]
        public string ActionName
        {
            get => _actionName;
            set
            {
                _actionName = value;

                // todo create more enum values for different types
                Action = EnumUtils.GetInternalValue<KudosuAction>(value.Split('.').Last());
            }
        }

        public KudosuAction? Action { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("model")]
        public string Target { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("giver")]
        public OsuKudosuGiver Giver { get; set; }

        [JsonProperty("post")]
        public OsuKudosuPost Post { get; set; }
    }
}
