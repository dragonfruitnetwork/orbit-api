// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.API.Objects.Auth;

#nullable enable

namespace DragonFruit.Orbit.API.Exceptions
{
    public class TokenExpiredException : Exception
    {
        public TokenExpiredException()
            : base("The token provided is invalid or has expired")
        {
        }

        public TokenExpiredException(OsuSessionTokenBase? token)
            : this()
        {
            Token = token;
        }

        public OsuSessionTokenBase? Token { get; set; }
    }
}
