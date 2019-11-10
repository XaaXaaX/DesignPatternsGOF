using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.ChainOfResponsability.LogicalChain
{
    public class ValidationHandler : IHandler
    {
        private readonly IValidationRequest request;
        private readonly IHandler next;
        private readonly ValidationTypes validationType;

        public ValidationHandler(
            IValidationRequest request, 
            ValidationTypes validationType, 
            IHandler handler)
        {
            this.request = request;
            this.next = handler;
            this.validationType = validationType;
        }

        public void Handle()
        {
            if (next != null)
            {
                next.Handle();
            }

            if ((next != null && request.Validated) || !request.Validated)
            {
                if (!request.Validations[this.validationType].Validate())
                    throw new Exception($"{this.validationType} Validation required");

                request.Validated = true;
            }
        }
    }
}
