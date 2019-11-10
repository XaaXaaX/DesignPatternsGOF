using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.ChainOfResponsability
{
    public class SecurityValidation : Validation, IValidation
    {
        public SecurityValidation(
            ValidationResult result,
            DateTime validationDate) : base(result, validationDate)
        { }

        public override bool Validate()
        {
            return ValidationDate.HasValue &&
                ValidationDate.Value != DateTime.MinValue &&
                result == ValidationResult.Valid;

        }
    }
}
