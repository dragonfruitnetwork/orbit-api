using System;
using DragonFruit.Orbit.API.Legacy;
using DragonFruit.Orbit.API.Legacy.Requests;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.API.Demo
{
    internal static class Program
    {
        private const string User = "PaPaCurry";

        private static void Main(string[] args)
        {
            var client = new OrbitDemoClient();

            var userInfo = client.Perform<LegacyOsuUser>(new LegacyUserRequest(User));
            var recentPlays = client.Perform<LegacyScore>(new LegacyUserRecentPerformancesRequest(User));

            Console.WriteLine(JsonConvert.SerializeObject(userInfo, Formatting.Indented));
            Console.WriteLine(JsonConvert.SerializeObject(recentPlays, Formatting.Indented));
        }
    }
}
