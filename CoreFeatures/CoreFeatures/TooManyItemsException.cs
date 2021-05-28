using System;
using System.Runtime.Serialization;

namespace CoreFeatures
{
    [Serializable]
    internal class TooManyItemsException : Exception
    {
        public TooManyItemsException()
        {
        }

        public TooManyItemsException(string message) : base(message)
        {
        }

        public TooManyItemsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TooManyItemsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}