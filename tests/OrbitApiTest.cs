﻿// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

namespace DragonFruit.Orbit.Api.Tests
{
    public abstract class OrbitApiTest
    {
        protected OrbitTestClient Client { get; } = new OrbitTestClient();
    }
}