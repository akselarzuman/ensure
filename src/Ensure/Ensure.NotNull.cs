using System;

namespace EnsureDotnet
{
    public static partial class Ensure
    {
        public static void ArgumentNotNull(in object value)
        {
            if (value != null)
            {
                return;
            }

            throw new ArgumentNullException();
        }
        
        public static void ArgumentNotNull(in object value, in string name)
        {
            if (value != null)
            {
                return;
            }

            throw new ArgumentNullException(name);
        }
    }
}