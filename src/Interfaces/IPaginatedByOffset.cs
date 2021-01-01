// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.Api.Interfaces
{
    public interface IPaginatedByOffset : IHasLimit
    {
        public uint Page { get; set; }

        public uint Offset { get; set; }
    }
}
