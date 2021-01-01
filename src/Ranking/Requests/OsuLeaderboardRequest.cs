// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Interfaces;
using DragonFruit.Orbit.Api.Ranking.Enums;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Ranking.Requests
{
    public class OsuLeaderboardRequest : OrbitRequest, IPaginatedByCursor
    {
        private string _country;
        private uint? _spotlight;
        private LeaderboardVariant? _variant;

        protected override string Stub => $"rankings/{Mode.ToExternalValue()}/{Type.ToExternalValue()}";
        protected override IEnumerable<KeyValuePair<string, string>> AdditionalQueries => CursorUtils.ToQueries(Cursor);

        public OsuLeaderboardRequest(GameMode mode, LeaderboardType type)
        {
            Mode = mode;
            Type = type;
        }

        public GameMode Mode { get; set; }
        public LeaderboardType Type { get; set; }
        public LeaderboardFilterMode? Filter { get; set; }

        [QueryParameter("filter")]
        public string FilterName => Filter?.ToExternalValue();

        [QueryParameter("country")]
        public string Country
        {
            get => Type != LeaderboardType.Country ? _country?.ToUpperInvariant() : null;
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
