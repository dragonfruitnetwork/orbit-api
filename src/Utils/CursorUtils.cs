// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using System.Linq;

namespace DragonFruit.Orbit.Api.Utils
{
    internal static class CursorUtils
    {
        public static IEnumerable<KeyValuePair<string, string>> ToQueries(IEnumerable<KeyValuePair<string, string>> values)
        {
            return values?.Select(x => new KeyValuePair<string, string>($"cursor[{x.Key}]", x.Value));
        }
    }
}
