using System.Collections.Generic;

namespace Behavioral.ChainOfResponsability
{
    public class ValidationRequest : IValidationRequest
    {
        public ValidationRequest(
            Dictionary<ValidationTypes, IValidation> validations)
        {
            this.Validations = validations;
        }
        public Dictionary<ValidationTypes, IValidation> Validations { get; private set; }

        public bool Validated { get; set; }
    }
}