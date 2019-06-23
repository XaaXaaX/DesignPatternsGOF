using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder
{
    public class EngineValidation : IValidation
    {
        public bool InProgress { get; set; }
        public DateTime ValidationDate { get; set; }
        public bool ValidatedBySupervisor { get; set; }
        public bool ValidateByMaster { get; set; }
    }
}
