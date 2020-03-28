
using DragonFruit.Common.Data;
using DragonFruit.Orbit.API.Enums;

namespace DragonFruit.Orbit.API.Users.Requests
{
    /// <summary>
    /// <see cref="ApiRequest"/> for endpoints interested in a specific <see cref="GameModes"/>
    /// </summary>
    public abstract class ModeBasedRequest : ApiRequest
    {
        public GameModes GameMode { get; set; } = GameModes.Default;

        public string ModeValue => GameMode == GameModes.Default ? string.Empty : ((int)GameMode).ToString();
    }
}
