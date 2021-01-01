// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading;
using DragonFruit.Common.Data.Services;
using DragonFruit.Orbit.Api.Auth;
using DragonFruit.Orbit.Api.Auth.Extensions;
using NUnit.Framework;

namespace DragonFruit.Orbit.Api.Tests
{
    public class OrbitTestClient : OrbitClient
    {
        private static string TokenCacheFile => Path.Combine(Path.GetTempPath(), "orbit-token.json");
        private readonly Dictionary<string, string> _envCache = new Dictionary<string, string>(3);

        protected override string LegacyKey => GetEnvironmentVariable("orbit_legacy_key");

        protected override string ClientId => GetEnvironmentVariable("orbit_client_id");
        protected override string ClientSecret => GetEnvironmentVariable("orbit_client_secret");

        protected override OsuAuthToken GetToken()
        {
            var token = FileServices.ReadFileOrDefault<OsuAuthToken>(TokenCacheFile);

            if (token?.Expired != false)
            {
                if (string.IsNullOrEmpty(ClientId) || string.IsNullOrEmpty(ClientSecret))
                    Assert.Inconclusive("Client Id/Secret Missing");

                token = this.GetSessionToken();

                FileServices.WriteFile(TokenCacheFile, token);
            }

            return token;
        }

        protected override void SetupRequest(HttpRequestMessage request)
        {
            // delay the api requests to reduce load on the server
            Thread.Sleep(2500);
        }

        private string GetEnvironmentVariable(string name)
        {
            if (_envCache.TryGetValue(name, out var value))
                return value;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                value = Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.User);
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                value = Environment.GetEnvironmentVariable(name);
            else
                throw new PlatformNotSupportedException();

            _envCache[name] = value;
            return value;
        }
    }
}
