// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;

namespace DragonFruit.Orbit.API.Exceptions
{
    public class LegacyApiException : Exception
    {
        public LegacyApiException(string error)
            : base(error)
        {
        }
    }
}
