using System;

namespace Chuck
{
    public static partial class Ensure
    {
        public static void IsNot<TException>(bool condition) where TException : Exception
        {
            if (condition)
            {
                var exception = Activator.CreateInstance<TException>();
                throw exception;
            }
        }

        public static void IsNot<TException>(bool condition, string userMessage) where TException : Exception
        {
            if (condition)
            {
                var exception = (TException)Activator.CreateInstance(typeof(TException), args: new object[] { userMessage });
                throw exception;
            }
        }
    }
}