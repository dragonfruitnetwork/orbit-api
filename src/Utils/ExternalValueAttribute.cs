// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;

namespace DragonFruit.Orbit.Api.Utils
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ExternalValueAttribute : Attribute
    {
        public ExternalValueAttribute(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}
