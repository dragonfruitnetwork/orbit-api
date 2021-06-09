// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Interfaces;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Ecosystem.Requests
{
    public class OsuNewsRequest : OrbitRequest, IPaginatedByCursor, IHasLimit
    {
        protected override string Stub => "news";
        protected override bool RequireAuth => false;

        protected override IEnumerable<KeyValuePair<string, string>> AdditionalQueries => CursorUtils.ToQueries(Cursor);

        [QueryParameter("limit")]
        public uint? Limit { get; set; }

        public IReadOnlyDictionary<string, string> Cursor { get; set; }
    }
}
