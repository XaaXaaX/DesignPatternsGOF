using System;
using System.Runtime.Serialization;

namespace Structural_Decorator
{
    [Serializable]
    internal class UnAuthorizedAmountException : Exception
    {
        public UnAuthorizedAmountException()
        {
        }

        public UnAuthorizedAmountException(string message) : base(message)
        {
        }

        public UnAuthorizedAmountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnAuthorizedAmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}