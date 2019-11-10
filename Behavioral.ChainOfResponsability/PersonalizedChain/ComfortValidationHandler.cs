using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.ChainOfResponsability.PersonalizedChain
{
    public class ComfortValidationHandler: IHandler
    {
        private readonly IValidationRequest request;
        private readonly IHandler next;
        private readonly IValidation validation;

        public ComfortValidationHandler(
            IValidationRequest request,
            IValidation validation,
            IHandler handler)
        {
            this.request = request;
            this.next = handler;
            this.validation = validation;

        }
        public void Handle()
        {
            if (next != null)
            {
                next.Handle();
            }

            if (!validation.Validate())
                throw new Exception("Security Validation required");

            request.Validated = true;
        }
    }
}
