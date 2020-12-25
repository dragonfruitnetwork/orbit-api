// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.Api.Interfaces
{
    public interface IPaginatedRequest : IPaginatedResponse
    {
        public uint? Limit { get; set; }
    }
}
