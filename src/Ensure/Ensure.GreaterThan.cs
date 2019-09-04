using System;

namespace EnsureDotnet
{
    public static partial class Ensure
    {
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

        public static void GreaterThanZero(in short value)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("short must be greater than zero");
        }

        public static void GreaterThanZero(in short value, in string name)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("short must be greater than zero", name);
        }

        public static void GreaterThanZero(in int value)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("int must be greater than zero");
        }

        public static void GreaterThanZero(in int value, in string name)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("int must be greater than zero", name);
        }

        public static void GreaterThanZero(in long value)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("long must be greater than zero");
        }

        public static void GreaterThanZero(in long value, in string name)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("long must be greater than zero", name);
        }

        public static void GreaterThanZero(in float value)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("float must be greater than zero");
        }

        public static void GreaterThanZero(in float value, in string name)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("float must be greater than zero", name);
        }

        public static void GreaterThanZero(in double value)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("double must be greater than zero");
        }

        public static void GreaterThanZero(in double value, in string name)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("double must be greater than zero", name);
        }

        public static void GreaterThanZero(in decimal value)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("decimal must be greater than zero");
        }

        public static void GreaterThanZero(in decimal value, in string name)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("decimal must be greater than zero", name);
        }
    }
}