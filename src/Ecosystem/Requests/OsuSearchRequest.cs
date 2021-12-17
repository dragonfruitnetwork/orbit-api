// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Data.Parameters;
using DragonFruit.Orbit.Api.Ecosystem.Enums;
using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.Ecosystem.Requests
{
    public class OsuSearchRequest : OrbitRequest
    {
        protected override string Stub => "search";

        public OsuSearchRequest(string query)
        {
            Query = query;
        }

        public SearchTarget? Target { get; set; }

        [QueryParameter("query")]
        public string Query { get; set; }

        [QueryParameter("page")]
        public int? Page { get; set; }

        [QueryParameter("mode")]
        public string ModeName => Target?.ToExternalValue();
    }
}
