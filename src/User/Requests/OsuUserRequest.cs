// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Orbit.Api.Utils;

namespace DragonFruit.Orbit.Api.User.Requests
{
    public class OsuUserRequest : OrbitRequest
    {
        protected override string Stub => $"users/{Identifier}/{ModeName}";

        public OsuUserRequest(string identifier)
        {
            Identifier = identifier;
        }

        public OsuUserRequest(string identifier, string modeName)
        {
            Identifier = identifier;
            ModeName = modeName;
        }

        public OsuUserRequest(string identifier, GameMode? mode)
        {
            Identifier = identifier;
            Mode = mode;
        }

        public string Identifier { get; set; }

        public GameMode? Mode
        {
            get => EnumUtils.GetInternalValue<GameMode>(ModeName);
            set => ModeName = value.ToExternalValue();
        }

        public string ModeName { get; set; }
    }
}
