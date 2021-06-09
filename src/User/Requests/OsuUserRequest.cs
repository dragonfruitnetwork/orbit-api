// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
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

        /// <summary>
        /// The user identifier to lookup (either a username or a user id)
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// If set, will inform the server the <see cref="Identifier"/> of its type.
        /// Leave as <c>null</c> to let the server predict the type.
        /// </summary>
        public bool? IsUsername { get; set; }

        /// <summary>
        /// The <see cref="GameMode"/> to return statistics for.
        /// </summary>
        public GameMode? Mode
        {
            get => EnumUtils.GetInternalValue<GameMode>(ModeName);
            set => ModeName = value.ToExternalValue();
        }

        /// <summary>
        /// The gamemode to return statistics for
        /// </summary>
        /// <remarks>
        /// If possible, use the <see cref="Mode"/> property for strongly-typed modes
        /// </remarks>
        public string ModeName { get; set; }

        [QueryParameter("key")]
        private string IdentifierType => IsUsername switch
        {
            true => "username",
            false => "id",

            _ => null
        };
    }
}
