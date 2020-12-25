// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Runtime.InteropServices;
using DragonFruit.Orbit.Api.Auth;
using DragonFruit.Orbit.Api.Auth.Extensions;

namespace DragonFruit.Orbit.Api.Tests
{
    public class OrbitTestClient : OrbitClient
    {
        protected override string LegacyKey => GetEnvironmentVariable("orbit_legacy_key");

        protected override string ClientId => GetEnvironmentVariable("orbit_client_id");
        protected override string ClientSecret => GetEnvironmentVariable("orbit_client_secret");

        protected override OsuAuthToken GetToken() => this.GetSessionToken();

        private static string GetEnvironmentVariable(string name)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.User);
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return Environment.GetEnvironmentVariable(name);
            }

            throw new PlatformNotSupportedException();
        }
    }
}
