using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.ChainOfResponsability
{
    public abstract class Validation : IValidation
    {
        protected readonly DateTime? ValidationDate;
        protected readonly ValidationResult result;

        public Validation(
            ValidationResult result,
            DateTime validationDate)
        {
            this.result = result;
            this.ValidationDate = validationDate;
        }

        public abstract bool Validate();
    }
}
