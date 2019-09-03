using System;
using System.Collections.Generic;
using System.Linq;

namespace Chuck
{
    public static partial class Ensure
    {
        public static void ArgumentNotNullOrEmptyString(string value, string name)
        {
            ArgumentNotNull(value, name);

            if (!string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            throw new ArgumentException("String cannot be empty", name);
        }

        public static void ArgumentNotNullOrEmptyEnumerable<T>(IEnumerable<T> value, string name)
        {
            ArgumentNotNull(value, name);

            if (value.Any())
            {
                return;
            }

            throw new ArgumentException("Enumerable cannot be empty", name);
        }
    }
}