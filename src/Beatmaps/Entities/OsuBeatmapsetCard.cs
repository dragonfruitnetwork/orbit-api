// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.Api.Beatmaps.Enums;
using DragonFruit.Orbit.Api.Utils;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Beatmaps.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuBeatmapsetCard
    {
        private string _statusName;

        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("title_unicode")]
        public string TitleUnicode { get; set; }

        [JsonProperty("artist_unicode")]
        public string ArtistUnicode { get; set; }

        [JsonProperty("covers")]
        public OsuBeatmapsetCovers Covers { get; set; }

        [JsonProperty("creator")]
        public string Mapper { get; set; }

        [JsonProperty("user_id")]
        public uint MapperUserId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("play_count")]
        public uint PlayCount { get; set; }

        [JsonProperty("video")]
        public bool HasVideo { get; set; }

        [JsonProperty("status")]
        public string StatusName
        {
            get => _statusName;
            set
            {
                _statusName = value;
                Status = EnumUtils.GetInternalValue<BeatmapsetStatus>(value);
            }
        }

        public BeatmapsetStatus? Status { get; set; }
    }
}
