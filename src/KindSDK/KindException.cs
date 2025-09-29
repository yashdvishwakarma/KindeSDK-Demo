using System;

namespace KindeSDK
{
    public class KindeAuthenticationException : Exception
    {
        public KindeAuthenticationException(string message) : base(message) { }

        public KindeAuthenticationException(string message, Exception innerException) : base(message, innerException) { }
    }
}
