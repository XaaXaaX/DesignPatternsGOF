using Behavioral.ChainOfResponsability;
using Behavioral.ChainOfResponsability.LogicalChain;
using System;
using System.Collections.Generic;
using Xunit;

namespace Behavioral.CahinOfResponsability
{
    public class LogicalCahinOfResponsabilityTest
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
                = new ValidationHandler(
                    request,
                    ValidationTypes.Comfort,
                    null);
            IHandler securityHandler
                = new ValidationHandler(
                    request, 
                    ValidationTypes.Security, 
                    comfortHandler);

            securityHandler.Handle();
        }
    }
}
