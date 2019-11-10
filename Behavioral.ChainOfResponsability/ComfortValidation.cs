using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.ChainOfResponsability
{
    public class ComfortValidation : Validation, IValidation
    {
        public ComfortValidation(
            ValidationResult result,
            DateTime validationDate) : base(result, validationDate)
        { }

        public override bool Validate()
        {
            return ValidationDate.HasValue &&
                ValidationDate.Value != DateTime.MinValue &&
                (result == ValidationResult.Valid ||
                result == ValidationResult.OnReview);
        }
    }
}
