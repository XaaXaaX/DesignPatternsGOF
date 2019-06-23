using System;

namespace Creational.Builder
{
    public interface IValidation
    {
        bool InProgress { get; set; }

        DateTime ValidationDate { get; set; }

        bool ValidatedBySupervisor { get; set; }

        bool ValidateByMaster { get; set; }
    }
}