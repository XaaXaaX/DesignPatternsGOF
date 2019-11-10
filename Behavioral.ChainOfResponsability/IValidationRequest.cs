using System.Collections.Generic;

namespace Behavioral.ChainOfResponsability
{
    public interface IValidationRequest
    {
        Dictionary<ValidationTypes, IValidation> Validations { get;}
        
        bool Validated { get; set; }
    }
}