// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using Newtonsoft.Json;

namespace DragonFruit.Orbit.Api.Utils
{
    /// <summary>
    /// <see cref="JsonConverter"/> for parsing <see cref="ExternalValueAttribute"/>d enums</summary>
    public class ExternalEnumConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                return;
            }

            writer.WriteValue(((Enum)value).ToExternalValue());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.Value?.ToString();
            return value != null ? objectType.GetDisplayValue(value) : null;
        }

        public override bool CanConvert(Type objectType) => objectType?.IsEnum == true;
    }
}
