// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Objects.Enums;
using DragonFruit.Orbit.API.Objects.Interfaces;

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuBeatmapsetSearchRequest : OrbitPaginatedRequest, IHasOptionalMode
    {
        protected override string Route => "/beatmapsets/search";
        protected override bool UsesOffset => false;

        public OsuBeatmapsetSearchRequest()
        {
        }

        /// <summary>
        /// Lookup potential maps based on a query
        /// </summary>
        public OsuBeatmapsetSearchRequest(string query)
        {
            Query = query;
        }

        public OsuBeatmapsetSearchRequest(string query, uint page)
            : this(query)
        {
            Page = page;
        }

        /// <summary>
        /// Lookup potential maps based on a query (with a specific mode)
        /// </summary>
        public OsuBeatmapsetSearchRequest(string query, GameMode mode)
            : this(query)
        {
            Mode = mode;
        }

        public OsuBeatmapsetSearchRequest(string query, GameMode mode, uint page)
            : this(query, mode)
        {
            Page = page;
        }

        public GameMode? Mode { get; set; }

        [QueryParameter("q")]
        public string Query
        {
            get => _query;
            set => _query = Uri.EscapeDataString(value);
        }

        [QueryParameter("m")]
        private string ModeQuery => Mode.ToQueryableValue();

        [QueryParameter("sort")]
        private string SortQuery => $"{Sort.ToString().ToLowerInvariant()}_{(SortDirection == SortDirection.Descending ? @"desc" : @"asc")}";

        [QueryParameter("s")]
        private string CategoryQuery => Category.ToString().ToLowerInvariant();

#nullable enable
        [QueryParameter("l")]
        private string? LanguageQuery => ((int?)Language)?.ToString();

        [QueryParameter("g")]
        private string? GenreQuery => ((int?)Genre)?.ToString();
#nullable restore

        public OsuBeatmapsetSearchCategory Category { get; set; } = OsuBeatmapsetSearchCategory.Any;
        public OsuBeatmapsetSearchSortCriteria Sort { get; set; } = OsuBeatmapsetSearchSortCriteria.Relevance;
        public SortDirection SortDirection { get; set; } = SortDirection.Descending;

        public OsuLanguage? Language { get; set; }
        public OsuBeatmapsetGenre? Genre { get; set; }

        private string _query;
    }
}
