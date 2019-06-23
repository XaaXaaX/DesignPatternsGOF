using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder
{
    public class FoundationValidation : IValidation
    {
        public bool InProgress { get; set; }
        public DateTime ValidationDate { get; set; }
        public bool ValidatedBySupervisor { get; set; }

        private bool _ValidateByMaster;
        public bool ValidateByMaster
        {
            get
            {
                if (ValidatedBySupervisor)
                {
                    _ValidateByMaster = true;
                }
                return _ValidateByMaster;
            }
            set { _ValidateByMaster = value; }
        }
    }
}
