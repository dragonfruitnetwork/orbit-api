
using DragonFruit.Common.Data;
using DragonFruit.Orbit.API.Enums;

namespace DragonFruit.Orbit.API.Users.Requests
{
    /// <summary>
    /// <see cref="ApiRequest"/> for endpoints interested in a specific <see cref="Modes"/>
    /// </summary>
    public abstract class ModeBasedRequest : ApiRequest
    {
        public Modes Mode { get; set; } = Modes.Default;

        public string ModeValue => Mode == Modes.Default ? string.Empty : ((int)Mode).ToString();
    }
}
