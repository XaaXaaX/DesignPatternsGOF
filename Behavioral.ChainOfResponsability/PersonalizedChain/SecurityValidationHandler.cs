using System;

namespace Behavioral.ChainOfResponsability.PersonalizedChain
{
    public class SecurityValidationHandler : IHandler
    {
        private readonly IValidationRequest request;
        private readonly IHandler next;
        private readonly IValidation validation;

        public SecurityValidationHandler(
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

            if (!PreRequirementConformed())
                throw new Exception("Security prerequirement validation required");

            if ( !validation.Validate())
                throw new Exception("Security validation required");

            request.Validated = true;
        }

        private static bool PreRequirementConformed()
        {
            // logical implementation to approve the requirement need
            // the method returns true for demonstration purpose
            return true;
        }
    }
}
