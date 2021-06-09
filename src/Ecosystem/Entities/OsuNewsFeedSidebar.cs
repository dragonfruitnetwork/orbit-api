// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Ecosystem.Entities
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class OsuNewsFeedSidebar
    {
        /// <summary>
        /// The current year to show expanded in the sidebar
        /// </summary>
        [JsonProperty("current_year")]
        public int CurrentYear { get; set; }

        /// <summary>
        /// The years with at least one news post
        /// </summary>
        [JsonProperty("years")]
        public int[] Years { get; set; }

        /// <summary>
        /// A collection of news posts. Likely intended to be sorted by year and displayed down the side of the program?
        /// </summary>
        [JsonProperty("news_posts")]
        public OsuNewsEntry[] NewsPosts { get; set; }
    }
}
