// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.Api.Ecosystem.Requests
{
    public class OsuWikiPageRequest : OrbitRequest
    {
        protected override string Stub => $"wiki/{Locale}/{PathStub}";

        protected override bool RequireAuth => false;

        public OsuWikiPageRequest(string locale, string path)
        {
            Locale = locale;
            PathStub = path;
        }

        public string Locale { get; set; }
        public string PathStub { get; set; }
    }
}
