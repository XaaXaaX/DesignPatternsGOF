using Behavioral.ChainOfResponsability;
using Behavioral.ChainOfResponsability.Generic_Chain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Behavioral.CahinOfResponsability.Test
{
    public class GenericCahinOfResponsabilityTest
    {
        [Fact]
        public void Handler_Shall_Pass_Validattion_to_next()
        {

            var validations = new Dictionary<ValidationTypes, IValidation>()
            {
                {
                    ValidationTypes.Security,
                    new SecurityValidation(
                        ValidationResult.Valid,
                        new DateTime(2019,10, 1))
                },
                {
                    ValidationTypes.Comfort,
                    new ComfortValidation(
                        ValidationResult.Valid,
                        new DateTime(2019,10, 1))
                }
            };

            IValidationRequest request
                = new ValidationRequest(validations);

            IHandler comfortHandler
                = new ValidationHandler<IValidationRequest, ComfortValidation>(
                    request,
                    new ComfortValidation(ValidationResult.OnReview, new DateTime(2019, 10, 1)),
                    null);
            IHandler securityHandler
                = new ValidationHandler<IValidationRequest, SecurityValidation>(
                    request,
                    new SecurityValidation(ValidationResult.Valid, new DateTime(2019, 10, 1)),
                    comfortHandler);

            securityHandler.Handle();

        }
    }
}
