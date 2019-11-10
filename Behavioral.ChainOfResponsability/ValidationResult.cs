using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.ChainOfResponsability
{
    public enum ValidationResult
    {
        NotValid=0,
        Valid,
        ReviewNeeded,
        OnReview,
        Rejected
    }
}
