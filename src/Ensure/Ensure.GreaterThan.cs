using System;
using System.Collections.Generic;

namespace EnsureDotnet
{
    public static partial class Ensure
    {
        public static void GreaterThanZero<T>(in T value) where T : IComparable<T>
        {
            ArgumentNotNull(value);

            if (Comparer<T>.Default.Compare(value, default) > 0)
            {
                return;
            }

            throw new ArgumentException($"{typeof(T)} must be greater than zero");
        }

        public static void GreaterThanZero<T>(in T value, in string message) where T : IComparable<T>
        {
            ArgumentNotNull(value);

            if (Comparer<T>.Default.Compare(value, default) > 0)
            {
                return;
            }

            throw new ArgumentException($"{typeof(T)} must be greater than zero", message);
        }

        public static void GreaterThanZero(in TimeSpan value)
        {
            ArgumentNotNull(value);

            if (value.TotalMilliseconds > 0)
            {
                return;
            }

            throw new ArgumentException("Timespan must be greater than zero");
        }

        public static void GreaterThanZero(in TimeSpan value, in string name)
        {
            ArgumentNotNull(value, name);

            if (value.TotalMilliseconds > 0)
            {
                return;
            }

            throw new ArgumentException("Timespan must be greater than zero", name);
        }
    }
}