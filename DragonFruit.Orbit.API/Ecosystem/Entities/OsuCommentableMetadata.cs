// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Utils;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuCommentableMetadata
    {
        private string _typeName;

        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public string TypeName
        {
            get => _typeName;
            set
            {
                _typeName = value;
                Type = EnumUtils.GetInternalValue<CommentableType>(value);
            }
        }

        public CommentableType? Type { get; set; }

        [JsonProperty("owner_id")]
        public uint? OwnerId { get; set; }

        [JsonProperty("owner_title")]
        public string OwnerTitle { get; set; }
    }
}
