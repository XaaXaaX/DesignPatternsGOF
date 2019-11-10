using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.ChainOfResponsability.Generic_Chain
{
    public class ValidationHandler<T, U> : IHandler
        where T: IValidationRequest
        where U: IValidation
    {
        private readonly T request;
        private readonly U validation;
        private readonly IHandler next;

        public ValidationHandler(
            T request, 
            U validation,
            IHandler next)
        {
            this.request = request;
            this.validation = validation;
            this.next = next;
        }
        public void Handle()
        {
            if (next != null)
            {
                next.Handle();
            }

            if ((next != null && request.Validated) || !request.Validated)
            {
                if (!validation.Validate())
                    throw new Exception($"{nameof(validation)} Validation required");

                request.Validated = true;
            }
        }
    }
}
