# Getting Started
![CI](https://github.com/dragonfruitnetwork/Orbit-API/workflows/Publish/badge.svg)
[![Codacy](https://api.codacy.com/project/badge/Grade/d4cc27241ce741a482169f3efaa018af)](https://www.codacy.com/gh/dragonfruitnetwork/Orbit-API)
[![NuGet](https://img.shields.io/nuget/v/DragonFruit.Orbit.API.svg?style=popout)](https://www.nuget.org/packages/DragonFruit.Orbit.API/)
[![DragonFruit Discord](https://img.shields.io/discord/482528405292843018?label=Discord&style=popout)](https://discord.gg/VA26u5Z)

Using the Orbit API is easy:

1. Get the latest version from NuGet (use the badge above)
2. Create a new class that inherits `OrbitClient` and fill some `protected` values out:

```c#
public class DragonFruitOrbitClient : OrbitClient
{
    //only set this if you are using API v1 features, otherwise it's useless
    protected override string LegacyApiKey => "abcdefg";

    //as with above, but instead ONLY in the case you'll be making session token requests for API v2
    protected override uint ClientId => 12221;
    protected override string ClientSecret => "abcdefg";

    protected override OsuSessionToken GetSessionToken()
    {
        //in here you need to write a method for getting an osu! access token that is **still valid**.

        //for a server you might want to use this.Perform(new OsuSessionCredentialRequest())
        //for a client you might want to contact your server with the user's refresh token and request a new access key.

        //in any scenario, you should **write the result to a file and check it first**, Orbit converts the "expires_in" to a datetime, so you can store it in a file
    }
}
```

3. Create a new instance of your class (you should only need one for the lifetime of the app):

### General C#

#### Creating
```c#
public static class Clients
{
    public static readonly DragonFruitOrbitClient Client = new DragonFruitOrbitClient();
}
```

#### Accessing
```c#
var user = Clients.Client.GetCurrentUser();
```

### ASP.Net Core (Dependency-Injection)

#### Creating
```c#
public void ConfigureServices(IServiceCollection services)
{
    //configure mvc, razor, auth, etc.
    services.AddSingleton<DragonFruitOrbitClient>();
}
```

#### Accessing

> You need to access this inside something else that is dependency-injected, like a controller or service

```c#
public class UserController : Controller
{
    private readonly DragonFruitOrbitClient _client;
    
    public UserController(DragonFruitOrbitClient client)
    {
        _client = client;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        _client.GetUser("PaPaCurry");
    }

}
```

