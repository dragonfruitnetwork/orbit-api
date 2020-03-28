using System;
using DragonFruit.Orbit.API.OAuth;

namespace DragonFruit.Orbit.API.Demo
{
    public class OrbitDemoClient : OrbitClient
    {
        protected override OAuthToken GetToken()
        {
            throw new NotImplementedException();
        }

        protected override string LegacyApiToken => Environment.GetEnvironmentVariable("osu!", EnvironmentVariableTarget.User);
    }
}
