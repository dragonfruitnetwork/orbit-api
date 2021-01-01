// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Collections.Generic;
using JetBrains.Annotations;

namespace DragonFruit.Orbit.Api.Interfaces
{
    public interface IPaginatedByCursor
    {
        [CanBeNull]
        public IReadOnlyDictionary<string, string> Cursor { get; set; }
    }
}
