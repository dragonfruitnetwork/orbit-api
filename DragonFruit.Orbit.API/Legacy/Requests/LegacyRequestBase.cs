using System;
using System.Collections.Generic;
using System.Text;
using DragonFruit.Common.Data;
using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.API.Enums;
using DragonFruit.Orbit.API.Legacy.Requests.Interfaces;

namespace DragonFruit.Orbit.API.Legacy.Requests
{
    public abstract class LegacyRequestBase : ApiRequest, IRequiresApiKey
    {
        [QueryParameter("k")]
        public string ApiKey { get; set; }

        [QueryParameter("u")]
        public string User { get; set; }

        [QueryParameter("m")]
        public Modes Mode { get; set; }

        [QueryParameter("type")]
        public string Type => IsUsername ? "string" : "id";

        public bool IsUsername { get; set; }
    }
}
