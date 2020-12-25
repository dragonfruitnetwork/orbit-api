// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.Api.Interfaces
{
    public interface IModeSpecificRequest
    {
        // todo add mode enum

        public string ModeName { get; set; }
    }
}
