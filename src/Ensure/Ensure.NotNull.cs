using System;

namespace Chuck
{
    public static partial class Ensure
    {
        public static void ArgumentNotNull(object value)
        {
            if (value != null)
            {
                return;
            }

            throw new ArgumentNullException();
        }
        
        public static void ArgumentNotNull(object value, string name)
        {
            if (value != null)
            {
                return;
            }

            throw new ArgumentNullException(name);
        }
    }
}