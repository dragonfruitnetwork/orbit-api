// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using System.Data;
using System.Linq;
using System.Reflection;
using JetBrains.Annotations;

namespace DragonFruit.Orbit.Api.Utils
{
    /// <summary>
    /// A set of enum utils for hadling enums and their externally visible values.
    /// </summary>
    /// <remarks>
    /// Lots of code has been reused from https://github.com/Humanizr/Humanizer/blob/master/src/Humanizer/EnumHumanizeExtensions.cs
    /// </remarks>
    internal static class EnumUtils
    {
        public static string ToExternalValue(this Enum value)
        {
            var enumType = value.GetType();
            var enumTypeInfo = enumType.GetTypeInfo();

            if (enumTypeInfo.GetCustomAttribute(typeof(FlagsAttribute)) != null && !Enum.IsDefined(enumType, value))
            {
                var values = Enum.GetValues(enumType)
                                 .Cast<Enum>()
                                 .Where(e => e.CompareTo(Convert.ChangeType(Enum.ToObject(enumType, 0), enumType)) != 0)
                                 .Where(value.HasFlag)
                                 .Select(e => e.ToExternalValue());

                return string.Join(",", values);
            }

            var elementName = value.ToString();
            var memInfo = enumTypeInfo.GetDeclaredField(elementName);

            if (memInfo != null && memInfo.GetCustomAttribute(typeof(ExternalValueAttribute)) is ExternalValueAttribute attribute)
            {
                return attribute.Value;
            }

            // default for these is lowercase
            return elementName.ToLowerInvariant();
        }

        [CanBeNull]
        public static T? GetInternalValue<T>(string value) where T : struct
        {
            var type = typeof(T);

            if (!type.IsEnum)
                throw new InvalidConstraintException($"{nameof(T)} was not an enum type");

            return Enum.GetValues(type)
                       .Cast<Enum>()
                       .FirstOrDefault(x => x.ToExternalValue() == value) as T?;
        }
    }
}
