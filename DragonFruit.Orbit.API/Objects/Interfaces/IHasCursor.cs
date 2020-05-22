// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Generic;

namespace DragonFruit.Orbit.API.Objects.Interfaces
{
    public interface IHasCursor
    {
        public Cursor Cursor { get; set; }
    }
}
