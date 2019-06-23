using System;
using System.Runtime.Serialization;

namespace Structural_Decorator
{
    [Serializable]
    internal class UnAuthorizedWithdrawAmount : Exception
    {
        public UnAuthorizedWithdrawAmount()
        {
        }

        public UnAuthorizedWithdrawAmount(string message) : base(message)
        {
        }

        public UnAuthorizedWithdrawAmount(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnAuthorizedWithdrawAmount(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}