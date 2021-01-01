// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Beatmaps.Enums;
using DragonFruit.Orbit.Api.Interfaces;
using DragonFruit.Orbit.Api.User.Enums;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Beatmaps.Requests
{
    public class OsuBeatmapsetSearchRequest : OrbitRequest, IPaginatedByCursor
    {
        private string _query;
        private BeatmapsetGenre? _genre;
        private BeatmapsetLanguage? _language;
        private BeatmapsetPlayStatus? _status;
        private BeatmapsetCategory? _category;
        private BeatmapsetSearchCriteria? _criteria;

        protected override string Stub => "beatmapsets/search";
        protected override IEnumerable<KeyValuePair<string, string>> AdditionalQueries => CursorUtils.ToQueries(Cursor);

        [QueryParameter("q")]
        public string Query
        {
            get => Uri.EscapeDataString(_query);
            set => _query = value;
        }

        [QueryParameter("m", EnumHandlingMode.Numeric)]
        public GameMode? Mode { get; set; }

        public bool Descending { get; set; } = true;

        public BeatmapsetPlayStatus? Status
        {
            get => _status ?? BeatmapsetPlayStatus.Any;
            set => _status = value;
        }

        public BeatmapsetCategory? Category
        {
            get => _category ?? BeatmapsetCategory.HasLeaderboard;
            set => _category = value;
        }

        public BeatmapsetSearchCriteria? Criteria
        {
            get => _criteria ?? BeatmapsetSearchCriteria.Ranked;
            set => _criteria = value;
        }

        public BeatmapSearchFlags? ExtraFlags { get; set; }
        public ScoreGrade? RankFilter { get; set; }

        [QueryParameter("g", EnumHandlingMode.Numeric)]
        public BeatmapsetGenre? Genre
        {
            get => _genre;
            set => _genre = value.HasValue && value != BeatmapsetGenre.Any ? value : null;
        }

        [QueryParameter("l", EnumHandlingMode.Numeric)]
        public BeatmapsetLanguage? Language
        {
            get => _language;
            set => _language = value.HasValue && value != BeatmapsetLanguage.Any ? value : null;
        }

        [QueryParameter("s")]
        protected string CategoryName => Category.ToExternalValue();

        [QueryParameter("played")]
        protected string PlayStatusName => Status == BeatmapsetPlayStatus.Any ? null : Status.ToExternalValue();

        [QueryParameter("sort")]
        protected string SortString => $"{Criteria.ToExternalValue()}_{(Descending ? "desc" : "asc")}";

        [QueryParameter("e")]
        protected string ExtraFlagsString => ExtraFlags?.ToExternalValue(".");

        [QueryParameter("r")]
        protected string RankFilterString => RankFilter?.ToExternalValue(".").ToUpperInvariant();

        public IReadOnlyDictionary<string, string> Cursor { get; set; }
    }
}
