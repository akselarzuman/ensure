using System;
using System.Collections.Generic;
using System.Linq;

namespace EnsureDotnet
{
    public static partial class Ensure
    {
        public static void ArgumentNotNullOrEmptyString(in string value, in string name)
        {
            ArgumentNotNull(value, name);

            if (!string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            throw new ArgumentException("String cannot be empty", name);
        }

        public static void ArgumentNotNullOrEmptyEnumerable<T>(in IEnumerable<T> value, in string name)
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