// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace DragonFruit.Orbit.Api.Utils
{
    public static class TokenUtils
    {
        public static IReadOnlyDictionary<string, object> DecodeBearerToken(string token)
        {
            var segments = token.Split('.');

            if (segments.Length != 3)
            {
                throw new ArgumentException("Invalid token provided");
            }

            var payload = Convert.FromBase64String(segments[1]);
            var asciiPayload = Encoding.ASCII.GetString(payload);

            return JObject.Parse(asciiPayload).ToObject<Dictionary<string, object>>();
        }
    }
}
