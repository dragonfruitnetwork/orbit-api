// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Interfaces;
using DragonFruit.Orbit.Api.Leaderboards.Enums;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Leaderboards.Requests
{
    public class OsuRankingRequest : OrbitRequest, IPaginatedContent
    {
        private string _country;
        private uint? _spotlight;
        private LeaderboardVariant? _variant;

        protected override string Stub => $"rankings/{Mode.ToExternalValue()}/{Type.ToExternalValue()}";
        protected override IEnumerable<KeyValuePair<string, string>> AdditionalQueries => CursorUtils.ToQueries(Cursor);

        public GameMode Mode { get; set; }
        public LeaderboardType Type { get; set; }

        [QueryParameter("filter")]
        public LeaderboardFilterMode? Filter { get; set; }

        [QueryParameter("country")]
        public string Country
        {
            get => Type == LeaderboardType.Country ? _country.ToUpperInvariant() : null;
            set => _country = value;
        }

        [QueryParameter("spotlight")]
        public uint? Spotlight
        {
            get => Type == LeaderboardType.Spotlight ? _spotlight : null;
            set => _spotlight = value;
        }

        [QueryParameter("variant")]
        public LeaderboardVariant? Variant
        {
            get => Mode == GameMode.Mania && Type == LeaderboardType.Performance ? _variant : null;
            set => _variant = value;
        }

        public IReadOnlyDictionary<string, string> Cursor { get; set; }
    }
}
