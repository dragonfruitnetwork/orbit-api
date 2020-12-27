// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using JetBrains.Annotations;

namespace DragonFruit.Orbit.Api.Interfaces
{
    public interface IPaginatedResponse
    {
        [CanBeNull]
        public IReadOnlyDictionary<string, string> Cursor { get; set; }
    }
}
