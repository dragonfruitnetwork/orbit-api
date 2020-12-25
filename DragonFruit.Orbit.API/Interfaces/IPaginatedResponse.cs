// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;

namespace DragonFruit.Orbit.Api.Interfaces
{
    public interface IPaginatedResponse
    {
        public IReadOnlyDictionary<string, string> Cursor { get; set; }
    }
}
