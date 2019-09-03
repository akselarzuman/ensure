using System;

namespace Chuck
{
    public static partial class Ensure
    {
        public static void GreaterThanZero(TimeSpan value, string name)
        {
            ArgumentNotNull(value, name);

            if (value.TotalMilliseconds > 0)
            {
                return;
            }

            throw new ArgumentException("Timespan must be greater than zero", name);
        }

        public static void GreaterThanZero(int value, string name)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("int must be greater than zero", name);
        }
    }
}