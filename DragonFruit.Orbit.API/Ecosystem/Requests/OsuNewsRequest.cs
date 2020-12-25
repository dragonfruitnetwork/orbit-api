// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using System.Linq;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Interfaces;

namespace DragonFruit.Orbit.Api.Ecosystem.Requests
{
    public class OsuNewsRequest : OrbitRequest, IPaginatedRequest
    {
        protected override string Stub => "news";

        protected override bool RequireAuth => false;
        protected override IEnumerable<KeyValuePair<string, string>> AdditionalQueries => Cursor?.Select(x => new KeyValuePair<string, string>($"cursor[{x.Key}]", x.Value));

        [QueryParameter("limit")]
        public uint? Limit { get; set; }

        public IReadOnlyDictionary<string, string> Cursor { get; set; }
    }
}
