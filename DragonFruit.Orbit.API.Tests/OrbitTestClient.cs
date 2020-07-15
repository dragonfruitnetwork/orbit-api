// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using DragonFruit.Common.Data.Services;
using DragonFruit.Orbit.API.Objects.Auth;
using DragonFruit.Orbit.API.Requests;

namespace DragonFruit.Orbit.API.Tests
{
    public sealed class OrbitTestClient : OrbitClient
    {
        //we will end up making a few requests, so try not to overload the servers.
        private readonly Random _numGen;

        public OrbitTestClient()
        {
            _numGen = new Random();
        }

        protected override string ClientId => GetKey("orbit_client_id");
        protected override string ClientSecret => GetKey("orbit_client_secret");
        protected override string LegacyApiKey => GetKey("orbit_legacy_api_key");

        protected override OsuSessionTokenBase GetSessionToken()
        {
            var tokenFile = Path.Combine(Path.GetTempPath(), "orbit.tkn");

            if (File.Exists(tokenFile))
            {
                var token = FileServices.ReadFile<OsuSessionTokenBase>(tokenFile);

                if (!token.Expired)
                {
                    return token;
                }
            }

            var newToken = Perform(new OsuSessionCredentialRequest());
            FileServices.WriteFile(tokenFile, newToken);
            return newToken;
        }

        public override T Perform<T>(OrbitApiRequest requestData)
        {
            Thread.Sleep(_numGen.Next(500, 2500));
            return base.Perform<T>(requestData);
        }

        private static string GetKey(string env) =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? Environment.GetEnvironmentVariable(env, EnvironmentVariableTarget.User)
                  ?? Environment.GetEnvironmentVariable(env, EnvironmentVariableTarget.Machine) ?? Environment.GetEnvironmentVariable(env)
                : Environment.GetEnvironmentVariable(env);
    }
}
