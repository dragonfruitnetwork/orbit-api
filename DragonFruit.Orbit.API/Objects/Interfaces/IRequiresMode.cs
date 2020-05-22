// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.API.Objects.Enums;

namespace DragonFruit.Orbit.API.Objects.Interfaces
{
    public interface IRequiresMode
    {
        public GameMode Mode { get; set; }
    }
}
