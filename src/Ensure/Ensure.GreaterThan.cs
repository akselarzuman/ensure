using System;

namespace Chuck
{
    public static partial class Ensure
    {
        public static void GreaterThanZero(TimeSpan value)
        {
            ArgumentNotNull(value);

            if (value.TotalMilliseconds > 0)
            {
                return;
            }

            throw new ArgumentException("Timespan must be greater than zero");
        }
        
        public static void GreaterThanZero(TimeSpan value, string name)
        {
            ArgumentNotNull(value, name);

            if (value.TotalMilliseconds > 0)
            {
                return;
            }

            throw new ArgumentException("Timespan must be greater than zero", name);
        }

        public static void GreaterThanZero(short value)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("short must be greater than zero");
        }
        
        public static void GreaterThanZero(short value, string name)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("short must be greater than zero", name);
        }
        
        public static void GreaterThanZero(int value)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("int must be greater than zero");
        }
        
        public static void GreaterThanZero(int value, string name)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("int must be greater than zero", name);
        }
        
        public static void GreaterThanZero(long value)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("long must be greater than zero");
        }
        
        public static void GreaterThanZero(long value, string name)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("long must be greater than zero", name);
        }
        
        public static void GreaterThanZero(float value)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("float must be greater than zero");
        }
        
        public static void GreaterThanZero(float value, string name)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("float must be greater than zero", name);
        }
        
        public static void GreaterThanZero(double value)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("double must be greater than zero");
        }
        
        public static void GreaterThanZero(double value, string name)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("double must be greater than zero", name);
        }
        
        public static void GreaterThanZero(decimal value)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("decimal must be greater than zero");
        }
        
        public static void GreaterThanZero(decimal value, string name)
        {
            if (value > 0)
            {
                return;
            }

            throw new ArgumentException("decimal must be greater than zero", name);
        }
    }
}